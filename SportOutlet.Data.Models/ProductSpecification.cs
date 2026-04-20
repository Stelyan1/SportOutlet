using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models
{
    public class ProductSpecification
    {
        [Comment("Identification")]
        public Guid Id { get; set; }

        [Comment("Material type")]
        public string Key { get; set; } = null!; //Material
        public string Value { get; set; } = null!; //Cotton

        [Comment("Is for product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
