using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; } = 0M;
        public Guid CategoryId { get; set; }
        public override string ToString()
        {
            return $"Book name: {Name}; Price: {PurchasePrice};";
        }

    }
}
