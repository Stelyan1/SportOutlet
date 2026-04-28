using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportOutlet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Configuration
{
    public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.HasKey(pv => pv.Id);

            builder.Property(pv => pv.Size)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(pv => pv.Stock)
                   .IsRequired();

            builder.HasOne(pv => pv.Product)
                   .WithMany(p => p.ProductVariants)
                   .HasForeignKey(pv => pv.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(SeedProductVariant());
        }

        private IEnumerable<ProductVariant> SeedProductVariant()
        {
            IEnumerable<ProductVariant> productVariants = new List<ProductVariant>()
            {
                //Shoes Nike AirMax Pulse
                new ProductVariant()
                {
                    Id = Guid.Parse("3f2a9c1e-7d5b-4a86-8c1f-9b2e7a3d6c83"),
                    Size = "44.5",
                    Stock = 20,
                    ProductId = new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10")
                },

                new ProductVariant()
                {
                    Id = Guid.Parse("b1e7d3a9-5c2f-4a84-9d6e-2a3f7c1b8d94"),
                    Size = "45",
                    Stock = 20,
                    ProductId = new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10")
                }, //Done

                //T-Shirt UnderArmour Launch
                new ProductVariant()
                {
                    Id = Guid.Parse("8c5a1d7e-2f3b-4a83-b9d1-7e6a2c3f1b05"),
                    Size = "L",
                    Stock = 20,
                    ProductId = new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21")
                },

                new ProductVariant()
                {
                    Id = Guid.Parse("d7a3c1f9-6b2e-4a88-8c5d-1f9e2b3a7c16"),
                    Size = "XL",
                    Stock = 20,
                    ProductId = new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21")
                }, //Done

                //BagSack Adidas Linear
                new ProductVariant()
                {
                    Id = Guid.Parse("1c9e7a2d-3b5f-4a85-9d1e-6a7c2b3f8e27"),
                    Size = "Adjustable",
                    Stock = 20,
                    ProductId = new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32")
                }, //Done

                //Pants Nike Offline Chill
                new ProductVariant()
                {
                    Id = Guid.Parse("6a2d3f9c-1e7b-4a86-8c5f-3d1b7a9e2c38"),
                    Size = "S",
                    Stock = 20,
                    ProductId = new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43")
                },

                new ProductVariant()
                {
                    Id = Guid.Parse("f3b1a7c9-2d5e-4a84-b6c1-8e7a3d2f9c49"),
                    Size = "M",
                    Stock = 20,
                    ProductId = new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43")
                }, //Done

                //Sweatshirt Under Armour Unstoppable
                new ProductVariant()
                {
                    Id = Guid.Parse("2e7c1a5d-9b3f-4a83-8d6e-1c2f7a9b3d50"),
                    Size = "S",
                    Stock = 20,
                    ProductId = new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54")
                },

                new ProductVariant()
                {
                    Id = Guid.Parse("9d1a3c7f-5b2e-4a88-9c6d-2f7a1e3b8c61"),
                    Size = "M",
                    Stock = 20,
                    ProductId = new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54")
                }, //Done


                //Under Armour Matching Shorts
                new ProductVariant()
                {
                    Id = Guid.Parse("1d7a9c3e-5b24-4f6a-8c1d-2e9f7b3a6c85"),
                    Size = "L",
                    Stock = 20,
                    ProductId = new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62")
                },

                new ProductVariant()
                {
                    Id = Guid.Parse("8b2f6d1c-9a73-4e5a-b4c2-7d1e3f9a6c08\r\n"),
                    Size = "XL",
                    Stock = 20,
                    ProductId = new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62")
                }, //Done


                //Nike Sport Essentials Jordan
                new ProductVariant()
                {
                    Id = Guid.Parse("5e3c1a7d-2f94-4b6a-9d1c-8a2e7f3b6c19"),
                    Size = "L",
                    Stock = 20,
                    ProductId = new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73")
                },

                new ProductVariant()
                {
                    Id = Guid.Parse("a2f9b6c3-4d71-4e8a-8c5d-3e7a1f2b9c60"),
                    Size = "XL",
                    Stock = 20,
                    ProductId = new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73")
                } //Done
            };
            return productVariants;
        }
    }
}
