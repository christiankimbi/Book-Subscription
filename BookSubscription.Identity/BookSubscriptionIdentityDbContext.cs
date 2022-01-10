using BookSubscription.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Identity
{
    public class BookSubscriptionIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookSubscriptionIdentityDbContext(DbContextOptions<BookSubscriptionIdentityDbContext> options) : base(options)
        {
        }

    }
}
