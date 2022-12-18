using AutoMapper;
using BookStoreAPI.Data;
using BookStoreAPI.Models.Author;
using BookStoreAPI.Models.Book;

namespace BookStoreAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadDto, Author>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<Book, BookReadDto>()
                .ForMember(q => q.AuthorName, i => i.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"))
                .ReverseMap();
            CreateMap<Book, BookReadDetails>()
                .ForMember(q => q.AuthorName, i => i.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"))
                .ReverseMap();
        }
    }
}
