using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models.ShopEntities
{
    public class Order
    {
        [Comment("Identification of Order")]
        public Guid Id { get; set; }

        [Comment("User for whom the order is created")]
        public Guid? UserId { get; set; }

        [Comment("Keep record of the date and time purchased")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Comment("Price of the order")]
        public decimal TotalPrice { get; set; }

        [Comment("Keep a list of ordered items")]
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
