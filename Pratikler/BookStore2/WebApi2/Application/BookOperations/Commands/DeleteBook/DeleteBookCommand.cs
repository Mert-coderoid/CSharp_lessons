using AutoMapper;
using WebApi2.DBOperations;

namespace WebApi2.Aplication.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly BookStoreDBContext _context;
        private readonly IMapper _mapper;
        public int BookId { get; set; }

        public DeleteBookCommand(BookStoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == BookId);
            if (book is null)
                throw new InvalidOperationException("Kitap bulunamadı.");
            
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}