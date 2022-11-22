using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi2.DBOperations;

namespace WebApi2.Aplication.BookOperations.Queries
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDBContext _context;
        private readonly IMapper _mapper;
        public int BookId { get; set; }

        public GetBookDetailQuery(BookStoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public BookDetailViewModel Handle()
        {
            var book = _context.Books.Include(x => x.Genre).Where(book => book.Id == BookId).SingleOrDefault();
            if (book is null)
                throw new InvalidOperationException("Kitap bulunamadı.");
            BookDetailViewModel viewModel = _mapper.Map<BookDetailViewModel>(book);
            return viewModel;
        }

    }

    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}