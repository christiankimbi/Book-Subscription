using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Domain.Entities
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public decimal PurchasePrice { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Book()
        {
            Name = string.Empty;
            Text = string.Empty;
            PurchasePrice = 0M;
            CategoryId = Guid.Empty;
            Category = new Category();
        }
    }


}
