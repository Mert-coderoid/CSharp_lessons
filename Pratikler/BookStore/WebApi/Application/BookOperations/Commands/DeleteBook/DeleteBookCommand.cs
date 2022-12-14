using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly BookStoreDBContext _dbContext;
        public int BookId { get; set; }
        public DeleteBookCommand(BookStoreDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == BookId);
            if(book is null)
                throw new InvalidOperationException("Silinecek Kitap bulunamad─▒.");
            
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
    }
}