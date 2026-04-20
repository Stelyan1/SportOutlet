using Microsoft.EntityFrameworkCore;

namespace SportOutlet.Data.Models
{
    public class Brand
    {
        [Comment("Identifier")]
        public Guid Id { get; set; }

        [Comment("Name")]
        public string Name { get; set; } = null!;

        [Comment("Brand Image")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Brand have Products")]
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
