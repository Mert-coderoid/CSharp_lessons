using AutoMapper;
using WebApi.BookOperations.GetBookDetail;
using WebApi.BookOperations.GetBooks;
using WebApi.Common;
using static WebApi.BookOperations.GetBooks.CreateBookCommand;

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