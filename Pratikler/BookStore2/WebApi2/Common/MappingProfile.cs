using AutoMapper;
using WebApi2.Aplication.BookOperations.Commands.CreateBook;
using WebApi2.Aplication.BookOperations.Commands.UpdateBook;
using WebApi2.Aplication.BookOperations.Queries;
using WebApi2.Aplication.BookOperations.Queries.GetBooks;
using WebApi2.Entities;

namespace WebApi2.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookViewModel>();
            CreateMap<Book, BookDetailViewModel>();
            CreateMap<CreateBookModel, Book>();
            CreateMap<UpdateBookModel, Book>();
        }
    }
}