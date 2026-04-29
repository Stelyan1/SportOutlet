using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models.ShopEntities
{
    public class Cart
    {
        [Comment("Identification of cart")]
        public Guid Id { get; set; }

        [Comment("User who ordered")]
        public Guid? UserId { get; set; }

        [Comment("One Cart can have many cart items inside")]
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
