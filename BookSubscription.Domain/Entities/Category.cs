using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

        public Category()
        {
            CategoryId = Guid.Empty;
            Name = string.Empty;
            Books = new List<Book>();
        }
    }
}
