using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Subscriptions.Queries.GetSubscriptionDetail
{
    public class GetSubscriptionDetailQuery : IRequest<SubscriptionDetailVm> 
    {
        public Guid SubscriptionId { get; set; }
    }
}
