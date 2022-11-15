using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.BookOperations.Querries.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDBContext _dbContext;
        private readonly IMapper _mapper;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDBContext dbContext, IMapper _mapper)
        {
            _dbContext = dbContext;
            this._mapper = _mapper;
        }

        public BookDetailViewModel Handle()
        {
            var book = _dbContext.Books.Include(x => x.Genre).Where(book => book.Id == BookId).SingleOrDefault();
            if (book is null)
                throw new InvalidOperationException("Kitap bulunamadı.");

            BookDetailViewModel viewModel =  _mapper.Map<BookDetailViewModel>(book);  // new BookDetailViewModel();
            // viewModel.Title = book.Title;
            // viewModel.Genre = ((GenreEnum)book.GenreId).ToString();
            // viewModel.PageCount = book.PageCount;
            // viewModel.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");
            return viewModel;
        }
    }

    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
    }
}
