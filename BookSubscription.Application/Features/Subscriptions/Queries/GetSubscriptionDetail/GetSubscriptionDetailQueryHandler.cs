using AutoMapper;
using BookSubscription.Application.Features.Subscriptions.Queries.Common;
using BookSubscription.Application.Interfaces.Persistence;
using BookSubscription.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Subscriptions.Queries.GetSubscriptionDetail
{
    public class GetSubscriptionDetailQueryHandler : IRequestHandler<GetSubscriptionDetailQuery, SubscriptionDetailVm>
    {

        private readonly IAsyncRepository<Subscription> _subscriptionRepository;
        private readonly IAsyncRepository<Book> _bookRepository;
        private readonly IMapper _mapper;

        public GetSubscriptionDetailQueryHandler(IAsyncRepository<Subscription> subscriptionRepository,  IAsyncRepository<Book> bookRepository, IMapper mapper)
        {
            _subscriptionRepository = subscriptionRepository;
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<SubscriptionDetailVm> Handle(GetSubscriptionDetailQuery request, CancellationToken cancellationToken)
        {
            var subsciption = await _subscriptionRepository.GetByIdAsync(request.SubscriptionId);
 
            var subscriptionVm = _mapper.Map<SubscriptionDetailVm>(subsciption);

            var book = await _bookRepository.GetByIdAsync(subsciption.BookId);
            subscriptionVm.Book = _mapper.Map<BookDto>(book);

            return subscriptionVm;
        }
    }
}
