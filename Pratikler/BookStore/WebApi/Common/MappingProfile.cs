using AutoMapper;
using WebApi.Application.BookOperations.GetBookDetail;
using WebApi.Application.BookOperations.GetBooks;
using WebApi.Common;
using WebApi.Entities;
using static WebApi.Application.BookOperations.GetBooks.CreateBookCommand;

namespace WebApi.AddControllers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BookDetailViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum) src.GenreId).ToString()));
            CreateMap<Book, BookViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum) src.GenreId).ToString()));
            // CreateMap<UpdateBookModel, Book>();
        }
    }
}