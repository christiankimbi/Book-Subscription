using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Subscriptions.Queries.Common
{
    public class BookDto
    {
        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; }
    }
}
