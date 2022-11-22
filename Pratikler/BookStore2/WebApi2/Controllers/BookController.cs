using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Aplication.BookOperations.Commands.CreateBook;
using WebApi2.Aplication.BookOperations.Commands.DeleteBook;
using WebApi2.Aplication.BookOperations.Commands.UpdateBook;
using WebApi2.Aplication.BookOperations.Queries;
using WebApi2.Aplication.BookOperations.Queries.GetBookDetail;
using WebApi2.Aplication.BookOperations.Queries.GetBooks;
using WebApi2.DBOperations;

namespace WebApi2.Controllers
{
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
        [Route("api/book")]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }

        [HttpGet]
        [Route("api/book/{id}")]
        public IActionResult GetBookById(int id)
        {
            BookDetailViewModel book;
            GetBookDetailQuery query = new GetBookDetailQuery(_context, _mapper);
            query.BookId = id;

            GetBookDetailQueryValidator validator = new GetBookDetailQueryValidator();
            validator.ValidateAndThrow(query);

            book = query.Handle();
            return Ok(book);
        }

        [HttpPost]
        [Route("api/book")]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            command.Model = newBook;

            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }

        [HttpPut]
        [Route("api/book/{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook)
        {
            UpdateBookCommand command = new UpdateBookCommand(_context, _mapper);
            command.BookId = id;
            command.Model = updatedBook;

            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }

        [HttpDelete]
        [Route("api/book/{id}")]
        public IActionResult DeleteBook(int id)
        {
            DeleteBookCommand command = new DeleteBookCommand(_context, _mapper);
            command.BookId = id;

            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
    }
}