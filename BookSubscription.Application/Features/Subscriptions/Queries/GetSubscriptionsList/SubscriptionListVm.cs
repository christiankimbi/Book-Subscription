using BookSubscription.Application.Features.Subscriptions.Queries.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Subscriptions.Queries.GetSubscriptionsList
{
    public class SubscriptionListVm
    {
        public Guid SubscriptionId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime RenewalDate { get; set; }
        public BookDto Book { get; set; } = new BookDto();
    }
}
