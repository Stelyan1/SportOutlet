using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models
{
    public class SubCategory
    {
        [Comment("Identifier")]
        public Guid Id { get; set; }


        [Comment("Name")]
        public string Name { get; set; } = null!;

        [Comment("Successor of category")]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Comment("Has products")]
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }   
}
