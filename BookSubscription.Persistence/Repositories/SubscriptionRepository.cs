using BookSubscription.Application.Interfaces.Persistence;
using BookSubscription.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Persistence.Repositories
{
    public class SubscriptionRepository : BaseRepository<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(BookSubscriptionDbContext dbContext) : base(dbContext)
        {
        }
    }
}
