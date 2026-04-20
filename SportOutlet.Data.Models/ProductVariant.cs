using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models
{
    public class ProductVariant
    {
        [Comment("Identification")]
        public Guid Id { get; set; }

        [Comment("Size")]
        public string Size { get; set; } = null!; //Could be L,S,XL,42,39.5

        [Comment("Stock")]
        public int Stock {  get; set; } 

        [Comment("For a product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
