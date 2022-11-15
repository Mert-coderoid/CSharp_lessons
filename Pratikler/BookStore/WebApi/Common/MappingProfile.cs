using AutoMapper;
using WebApi.Application.BookOperations.Querries.GetBookDetail;
using WebApi.Application.BookOperations.Querries.GetBooks;
using WebApi.Common;
using WebApi.Entities;
using static WebApi.Application.BookOperations.Commands.CreeateBook.CreateBookCommand;
using static WebApi.Application.GenreOperations.Queries.GetGenreDetail.GetGenreDetailQuery;
using static WebApi.Application.GenreOperations.Queries.GetGenres.GetGenresQuery;

namespace WebApi.AddControllers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BookDetailViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name));
            CreateMap<Book, BookViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name));
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
        }
    }
}