using AutoMapper;
using BookSubscription.Application.Features.Books.Queries.GetBookDetails;
using BookSubscription.Application.Features.Books.Queries.GetBooksList;
using BookSubscription.Application.Features.Categories.Queries.GetCategoryList;
using BookSubscription.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDetailVm>().ReverseMap();
            CreateMap<Book, BookListVm>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVm>().ReverseMap();


        }
    }
}
