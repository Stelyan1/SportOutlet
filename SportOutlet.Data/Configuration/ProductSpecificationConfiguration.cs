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
    public class ProductSpecificationConfiguration : IEntityTypeConfiguration<ProductSpecification>
    {
        public void Configure(EntityTypeBuilder<ProductSpecification> builder)
        {
            builder.HasKey(ps => ps.Id);

            builder.Property(ps => ps.Key)
                   .HasMaxLength(25)
                   .IsRequired();

            builder.Property(ps => ps.Value)
                   .HasMaxLength(25)
                   .IsRequired();

            builder.HasOne(ps => ps.Product)
                   .WithMany(p => p.ProductSpecifications)
                   .HasForeignKey(ps => ps.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(SeedProductSpecifications());
        }

        private IEnumerable<ProductSpecification> SeedProductSpecifications()
        {
            IEnumerable<ProductSpecification> productSpecifications = new List<ProductSpecification>()
            {
              //For Nike Air Max Pulse
              new ProductSpecification()
              {
                  Id = Guid.Parse("a1c5e9d2-7b3f-4a86-8d1c-9e2f7b3a6c38"),
                  Key = "Color",
                  Value = "Black",
                  ProductId = new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10")
              },

              //T-Shirt Under Armour Launch
              new ProductSpecification()
              {
                  Id = Guid.Parse("6e2b7a1d-9c3f-4a83-b5d1-2f8a7c9e4d49"),
                  Key = "Color",
                  Value = "Black",
                  ProductId = new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21")
              },

              //BagSack Adidads Linear
              new ProductSpecification()
              {
                  Id = Guid.Parse("d3a7c1e9-5b2f-4a88-9c6e-7d1a2b3f8c50"),
                  Key = "Color",
                  Value = "Black",
                  ProductId = new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32")
              },

              //Pants Nike Offline Chill
              new ProductSpecification()
              {
                  Id = Guid.Parse("2b9e5a7c-1d3f-4a84-8c2e-6f7a1b9d3c61"),
                  Key = "Color",
                  Value = "Green",
                  ProductId = new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43")
              },
              
              //Sweatshirt Under Armour Unstoppable
              new ProductSpecification()
              {
                  Id = Guid.Parse("f8c1a3d7-6e2b-4a85-9d5f-3b7a2c1e8d72"),
                  Key = "Color",
                  Value = "Pink",
                  ProductId = new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54")
              },

              //Under Armour Launch Matching Shorts
              new ProductSpecification()
              {
                  Id = Guid.Parse("6f1a9c3e-2b74-4d8a-9c5e-1e7a3f8b6c92"),
                  Key = "Color",
                  Value = "Black",
                  ProductId = new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62")
              },

              //Nike Sportswear Jordan 
              new ProductSpecification()
              {
                  Id = Guid.Parse("d3b7e2a1-9c54-4f6a-8d1c-2a7f9e3b6c81"),
                  Key = "Color",
                  Value = "Black",
                  ProductId = new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73")
              }
            };

            return productSpecifications;
        }
    }
}
