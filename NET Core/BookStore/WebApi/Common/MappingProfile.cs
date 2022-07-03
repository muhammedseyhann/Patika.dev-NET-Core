using AutoMapper;
using WebApi.Application.AuthorOperations.CreateAuthorCommand;
using WebApi.Application.AuthorOperations.GetAuthorDetailQuery;
using WebApi.Application.AuthorOperations.GetAuthorsQueries;
using WebApi.Application.BookOperations.Commands.CreateBookCommand;
using WebApi.Application.BookOperations.Queries.GetBookDetailQuery;
using WebApi.Application.BookOperations.Queries.GetBooksQuery;
using WebApi.Application.GenreOperations.Queries.GetGenres;
using WebApi.Application.GenreOperations.Queries.GetGenresDetailQuery;
using WebApi.Entities;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();//İlk parametre source, ikincisi target.
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name)).ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name + " " + src.Author.Surname));
            CreateMap<Book, BookDetailViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name)).ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name + " " + src.Author.Surname));
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
            CreateMap<Author, GetAuthorsViewModel>();
            CreateMap<Author, GetAuthorDetailViewModel>();
            CreateMap<CreateAuthorModel, Author>();
        }
    }
}