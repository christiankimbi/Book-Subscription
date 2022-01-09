using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Subscriptions.Queries.GetSubscriptionDetail
{
    public class SubscriptionDetailVm
    {
        public Guid SubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set; } = new UserDto();
        public Guid BookId { get; set; }
        public BookDto Book { get; set; } =  new BookDto();
        public DateTime StartDate { get; set; }
        public DateTime RenewalDate { get; set; }
    }
}
