using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Books.Queries.GetBooksList
{
    public class BookListVm
    {
        public Guid BookId { get; set; }
        public string Name { get; set; } = String.Empty;
        public decimal PurchasePrice { get; set; } = 0M;
    }
}
