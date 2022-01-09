using AutoMapper;
using BookSubscription.Application.Interfaces.Persistance;
using BookSubscription.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Books.Queries.GetBookDetails
{
    public class GetBookDetailQueryHandler : IRequestHandler<GetBookDetailQuery, BookDetailVm>
    {

        private readonly IAsyncRepository<Book> _bookRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetBookDetailQueryHandler(IAsyncRepository<Book> bookRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BookDetailVm> Handle(GetBookDetailQuery request, CancellationToken cancellationToken)
        {
            var bookObject = await _bookRepository.GetByIdAsync(request.Id);

            var bookDetail = _mapper.Map<BookDetailVm>(bookObject);

            var category = await _categoryRepository.GetByIdAsync(bookObject.CategoryId);


            bookDetail.Category = _mapper.Map<CategoryDto>(category);

            return bookDetail;
        }
    }
}
