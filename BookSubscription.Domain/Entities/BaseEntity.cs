using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Domain.Entities
{
    public class BaseEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool Active { get; set; }

        public BaseEntity()
        {
            CreatedBy = string.Empty;
            CreatedDate = DateTime.Now;
            LastModifiedBy = string.Empty;
            LastModifiedDate = null;
            Active = true;
        }

    }
}
