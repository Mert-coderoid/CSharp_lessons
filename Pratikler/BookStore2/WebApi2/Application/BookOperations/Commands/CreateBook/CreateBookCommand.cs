using AutoMapper;
using WebApi2.DBOperations;
using WebApi2.Entities;

namespace WebApi2.Aplication.BookOperations.Commands.CreateBook
{
    public class CreateBookCommand
    {
        private readonly BookStoreDBContext _context;
        private readonly IMapper _mapper;
        public CreateBookModel Model {get; set;}

        public CreateBookCommand(BookStoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.Title == Model.Title);
            if(book is not null)
                throw new InvalidOperationException("Kitap zaten mevcut.");
            book = _mapper.Map<Book>(Model);

            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }

    public class CreateBookModel
    {
        public string Title {get; set;}
        public int PageCount {get; set;}
        public int GenreId {get; set;}
        public int WriterId {get; set;}
        public DateTime PublishDate {get; set;}
    }
}