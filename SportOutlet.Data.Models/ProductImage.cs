using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models
{
    public class ProductImage
    {
        [Comment("Identification")]
        public Guid Id { get; set; }

        [Comment("Image")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Should have order to prevent chaos")]
        public int Order { get; set; }

        [Comment("Belongs to a product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
