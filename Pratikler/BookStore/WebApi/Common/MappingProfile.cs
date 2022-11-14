using AutoMapper;
using WebApi.Application.BookOperations.Querries.GetBookDetail;
using WebApi.Application.BookOperations.Querries.GetBooks;
using WebApi.Common;
using WebApi.Entities;
using static WebApi.Application.BookOperations.Commands.CreeateBook.CreateBookCommand;


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