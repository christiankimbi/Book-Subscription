using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Domain.Entities
{
    public class Subscription : BaseEntity
    {
        public Guid SubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }

        public DateTime StartDate {get; set; }
        public DateTime RenewalDate {get; set;}

        public Subscription()
        {
            StartDate = DateTime.Now;
            RenewalDate = StartDate.AddMonths(1);
            User = new User();
            Book = new Book();
        }
    }
}
