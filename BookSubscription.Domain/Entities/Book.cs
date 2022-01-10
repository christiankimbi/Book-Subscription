using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Domain.Entities
{
    public class Book : BaseEntity
    {
       
        public Guid BookId { get; set; }

        [Required] [MaxLength(50)]
        public string Name { get; set; }
        [Required]
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
        }
    }


}
