using BookSubscription.Application.Interfaces.Persistence;
using BookSubscription.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Persistence.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(BookSubscriptionDbContext dbContext) : base(dbContext)
        {
        }
    }
}
