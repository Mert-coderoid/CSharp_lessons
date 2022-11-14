using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.BookOperations.Commands.DeleteBook;
using WebApi.Application.BookOperations.Querries.GetBookDetail;
using WebApi.Application.BookOperations.Querries.GetBooks;
using WebApi.Application.BookOperations.Commands.UpdateBook;
using WebApi.DBOperations;
using static WebApi.Application.BookOperations.Commands.CreeateBook.CreateBookCommand;
using WebApi.Application.BookOperations.Commands.CreeateBook;
using static WebApi.Application.BookOperations.Commands.UpdateBook.UpdateBookCommand;

namespace WebApi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDBContext _context;
        private readonly IMapper _mapper;

        public BookController(BookStoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {

            GetBooksQuery query = new GetBooksQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            BookDetailViewModel result;
            GetBookDetailQuery query = new GetBookDetailQuery(_context, _mapper);
            query.BookId = id;
            GetBookDetailQueryValidation validator = new GetBookDetailQueryValidation();
            validator.ValidateAndThrow(query);
            result = query.Handle();

            return Ok(result);
        }


        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            command.Model = newBook;
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook)
        {
            UpdateBookCommand command = new UpdateBookCommand(_context);
            command.BookId = id;
            command.Model = updatedBook;
            UpdateBookCommandValidation validator = new UpdateBookCommandValidation();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            DeleteBookCommand command = new DeleteBookCommand(_context);
            command.BookId = id;
            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();

            return Ok();
        }
    }
}