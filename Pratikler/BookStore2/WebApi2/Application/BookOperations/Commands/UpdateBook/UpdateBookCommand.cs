using AutoMapper;
using WebApi2.DBOperations;

namespace WebApi2.Aplication.BookOperations.Commands.UpdateBook
{
    public class UpdateBookCommand
    {
        private readonly BookStoreDBContext _context;
        private readonly IMapper _mapper;
        public int BookId {get; set;}
        public UpdateBookModel Model {get; set;}
        
        public UpdateBookCommand(BookStoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == BookId);
            if(book is null)
                throw new InvalidOperationException("Kitap bulunamadı.");
            
            book.GenreId = Model.GenreId != default ? Model.GenreId : book.GenreId; // string default değeri null, int default değeri 0
            book.Title = Model.Title != default ? Model.Title : book.Title; 
            book.PageCount = Model.PageCount != default ? Model.PageCount : book.PageCount;
            book.PublishDate = Model.PublishDate != default ? Model.PublishDate : book.PublishDate;
            book.WriterId = Model.WriterId != default ? Model.WriterId : book.WriterId;

            _context.SaveChanges();
        }
    }

    public class UpdateBookModel
    {
        public string Title {get; set;}
        public int PageCount {get; set;}
        public int GenreId {get; set;}
        public int WriterId {get; set;}
        public DateTime PublishDate {get; set;}
    }
}