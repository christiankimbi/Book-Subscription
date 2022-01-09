using AutoMapper;
using BookSubscription.Application.Interfaces.Persistence;
using BookSubscription.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Subscriptions.Queries.GetSubscriptionsList
{
    public class GetSubscriptionListQueryHandler : IRequestHandler<GetSubscriptionListQuery, List<SubscriptionListVm>>
    {

        private readonly IAsyncRepository<Subscription> _subscriptionRepository;
        private readonly IMapper _mapper;

        public GetSubscriptionListQueryHandler(IAsyncRepository<Subscription> subscriptionRepository, IMapper mapper)
        {
            _subscriptionRepository = subscriptionRepository;
            _mapper = mapper;
        }

        public async Task<List<SubscriptionListVm>> Handle(GetSubscriptionListQuery request, CancellationToken cancellationToken)
        {

            var allUserSubscription = (await _subscriptionRepository.ListAllAsync()).Where(s => s.UserId == request.UserId);
            
            return _mapper.Map<List<SubscriptionListVm>>(allUserSubscription);

        }
    }
}
