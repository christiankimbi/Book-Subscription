using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Books.Queries.GetBookDetails
{
    public class BookDetailVm
    {
        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty ;
        public decimal PurchasePrice { get; set; } = 0M;
        public Guid CategoryId { get; set; }
        public CategoryDto Category { get; set; } = new CategoryDto();

    }
}
