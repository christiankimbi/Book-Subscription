using AutoMapper;
using BookSubscription.Application.Features.Books.Commands.CreateBook;
using BookSubscription.Application.Features.Books.Commands.DeleteBook;
using BookSubscription.Application.Features.Books.Commands.UpdateBook;
using BookSubscription.Application.Features.Books.Queries.GetBookDetails;
using BookSubscription.Application.Features.Books.Queries.GetBooksList;
using BookSubscription.Application.Features.Categories.Queries.GetCategoryList;
using BookSubscription.Application.Features.Subscriptions.Queries.Common;
using BookSubscription.Application.Features.Subscriptions.Queries.GetSubscriptionDetail;
using BookSubscription.Application.Features.Subscriptions.Queries.GetSubscriptionsList;
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
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, CreateBookCommand>().ReverseMap();
            CreateMap<Book, DeleteBookCommand>().ReverseMap();
            CreateMap<Book, UpdateBookCommand>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVm>().ReverseMap();

   
            CreateMap<Subscription, SubscriptionDetailVm>().ReverseMap();
            CreateMap<Subscription, SubscriptionListVm>().ReverseMap();

        }
    }
}
