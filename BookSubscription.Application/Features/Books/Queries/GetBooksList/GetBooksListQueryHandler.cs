using AutoMapper;
using BookSubscription.Application.Interfaces.Persistance;
using BookSubscription.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Books.Queries.GetBooksList
{
    public class GetBooksListQueryHandler : IRequestHandler<GetBooksListQuery, List<BookListVm>>
    {
        private readonly IAsyncRepository<Book> _bookRepository;
        private readonly IMapper _mapper;

        public GetBooksListQueryHandler(IAsyncRepository<Book> bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookListVm>> Handle(GetBooksListQuery request, CancellationToken cancellationToken)
        {
            var allBooks = (await _bookRepository.ListAllAsync()).OrderByDescending(b => b.LastModifiedDate).ToList();
            return _mapper.Map<List<BookListVm>>(allBooks);
        }
    }
}
