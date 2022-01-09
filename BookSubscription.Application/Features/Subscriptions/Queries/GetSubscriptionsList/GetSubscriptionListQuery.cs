using BookSubscription.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Subscriptions.Queries.GetSubscriptionsList
{
    public class GetSubscriptionListQuery : IRequest<List<SubscriptionListVm>>
    {
        public Guid UserId { get; set; }
    }
}
