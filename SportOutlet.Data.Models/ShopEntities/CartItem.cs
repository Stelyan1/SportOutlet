using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models.ShopEntities
{
    public class CartItem
    {
        [Comment("Identification of CartItem")]
        public Guid Id { get; set; }

        [Comment("Identification of Cart")]
        public Guid CartId { get; set; }
        public Cart Cart { get; set; } = null!;

        [Comment("Identification of product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public string Size { get; set; } = null!;

        [Comment("How many items")]
        public int Quantity { get; set; } 
    }
}
