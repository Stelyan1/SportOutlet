using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models.ShopEntities
{
    public class OrderItem
    {
        [Comment("Identification of the ordered item")]
        public Guid Id { get; set; }

        [Comment("Given product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [Comment("Belongs to an order")]
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public string Size { get; set; } = null!;

        [Comment("Quantity of ordered items")]
        public int Quantity { get; set; }

        public decimal currentPrice { get; set; }


    }
}
