using Microsoft.EntityFrameworkCore;
using SportOutlet.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models
{
    public class Product
    {
        [Comment("Identifier")]
        public Guid Id { get; set; }

        [Comment("Name")]
        public string Name { get; set; } = null!;

        [Comment("Price")]
        public decimal Price { get; set; }

        [Comment("Description")]
        public string Description { get; set; } = null!;

        [Comment("Images")]
        public ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();

        [Comment("Sizing")]
        public Gender Gender { get; set; }

        [Comment("SubCategoryBelonging")]
        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } = null!;

        [Comment("Hiding when out of stock")]
        public bool IsActive { get; set; }

        [Comment("BrandBelonging")]
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        [Comment("Has product specifications")]
        public ICollection<ProductSpecification> ProductSpecifications { get; set; } = new HashSet<ProductSpecification>();

        [Comment("Has product variations")]
        public ICollection<ProductVariant> ProductVariants { get; set; } = new HashSet<ProductVariant>();

    }
}
