using BookSubscription.Application.Interfaces.Persistence;
using BookSubscription.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookSubscriptionDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithBooks()
        {
            var allCategories = await _dbContext.Categories.Include(x => x.Books).ToListAsync();
            return allCategories;
        }

    }
}
