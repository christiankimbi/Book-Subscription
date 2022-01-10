using BookSubscription.Application.Interfaces;
using BookSubscription.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Persistence
{
    public class BookSubscriptionDbContext : DbContext
    {
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        private readonly ILoggedInUserService _loggedInUserService;

        public BookSubscriptionDbContext(DbContextOptions<BookSubscriptionDbContext> options, ILoggedInUserService loggedInUserService) : base(options)
        {
            _loggedInUserService = loggedInUserService;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookSubscriptionDbContext).Assembly);

            var userUID = Guid.Parse("{667a3c42-9251-471d-a645-98be3b12defa}");

            var fictionGuid = Guid.NewGuid();
            var romanceGuid = Guid.NewGuid();
            var thrillerGuid = Guid.NewGuid();
            var horrorGuid = Guid.NewGuid();

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = fictionGuid,
                Name = "Fiction",
                CreatedBy = userUID.ToString(),
                LastModifiedBy = userUID.ToString()
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = romanceGuid,
                Name = "Romance",
                CreatedBy = userUID.ToString(),
                LastModifiedBy = userUID.ToString()
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = thrillerGuid,
                Name = "Thriller",
                CreatedBy = userUID.ToString(),
                LastModifiedBy = userUID.ToString()
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = horrorGuid,
                Name = "Horror",
                CreatedBy = userUID.ToString(),
                LastModifiedBy = userUID.ToString()
            });


            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = Guid.NewGuid(),
                Name = string.Join(' ', Faker.Lorem.Words(5)),
                Text = Faker.Lorem.Paragraph(),
                PurchasePrice = 20,
                CategoryId = fictionGuid,
                CreatedBy = userUID.ToString(),
                LastModifiedBy = userUID.ToString()

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = Guid.NewGuid(),
                Name = string.Join(' ', Faker.Lorem.Words(5)),
                Text = Faker.Lorem.Paragraph(),
                PurchasePrice = 60,
                CategoryId = horrorGuid,
                CreatedBy = userUID.ToString(),
                LastModifiedBy = userUID.ToString()

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = Guid.NewGuid(),
                Name = string.Join(' ', Faker.Lorem.Words(5)),
                Text = Faker.Lorem.Paragraph(),
                PurchasePrice = 45,
                CategoryId = romanceGuid,
                CreatedBy = userUID.ToString(),
                LastModifiedBy = userUID.ToString()

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = Guid.NewGuid(),
                Name = string.Join(' ', Faker.Lorem.Words(5)),
                Text = Faker.Lorem.Paragraph(),
                PurchasePrice = 30,
                CategoryId = thrillerGuid,
                CreatedBy = userUID.ToString(),
                LastModifiedBy = userUID.ToString()

            });

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = _loggedInUserService.UserId;
                        entry.Entity.LastModifiedBy = entry.Entity.CreatedBy;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = _loggedInUserService.UserId;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
