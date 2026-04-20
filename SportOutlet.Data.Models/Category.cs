using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models
{
    public class Category
    {
        [Comment("Identifier")]
        public Guid Id { get; set; }

        [Comment("Name")]
        public string Name { get; set; } = null!;

        [Comment("Category Image")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Collection of SubCategories")]
        public ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();
    }
}
