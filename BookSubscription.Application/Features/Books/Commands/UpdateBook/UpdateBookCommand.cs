using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Books.Commands.UpdateBook
{
    public class UpdateBookCommand : IRequest
    {
        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = String.Empty;
        public decimal PurchasePrice { get; set; }
        public Guid CategoryId { get; set; }

    }
}
