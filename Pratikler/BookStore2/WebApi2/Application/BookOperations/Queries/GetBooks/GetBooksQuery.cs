using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi2.DBOperations;
using WebApi2.Entities;

namespace WebApi2.Aplication.BookOperations.Queries.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDBContext _context;
        private readonly IMapper _mapper;

        public GetBooksQuery(BookStoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<BookViewModel> Handle()
        {
            var bookList = _context.Books.Include(x => x.Genre).OrderBy(x => x.Id).ToList<Book>();
            List<BookViewModel> viewModel = _mapper.Map<List<BookViewModel>>(bookList);
            return viewModel;
        }
    }

    public class BookViewModel
    {
        public string Title {get; set;}
        public int PageCount {get; set;}
        public int GenreId {get; set;}
        public int WriterId {get; set;}
        public DateTime PublishDate {get; set;}
    }
}