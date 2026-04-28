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
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(pi => pi.Id);

            builder.Property(pi => pi.ImageUrl)
                   .IsRequired();

            builder.Property(pi => pi.Order)
                   .IsRequired();

            builder.HasOne(pi => pi.Product)
                   .WithMany(p => p.ProductImages)
                   .HasForeignKey(pi => pi.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(SeedProductImage());
        }

        private IEnumerable<ProductImage> SeedProductImage()
        {
            IEnumerable<ProductImage> productImages = new List<ProductImage>()
            {
                //Shoes Start
                new ProductImage()
                {
                    Id = Guid.Parse("6c2f9e1a-3b7d-4a85-9f2c-8d1e7b3a5c60"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/HJ5/HJ5178-001/images/thumbs_600/HJ5178-001_600_600px.jpg",
                    Order = 1,
                    ProductId = new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("b7a1d3c9-5e2f-4d88-a6c4-2f9e1b7a3d71"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/HJ5/HJ5178-001/images/thumbs_600/HJ5178-001_1_600_600px.jpg",
                    Order = 2,
                    ProductId = new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("2d8c5a7e-1f3b-4a9c-b6d2-9e7a1c3f8b82"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/HJ5/HJ5178-001/images/thumbs_600/HJ5178-001_2_600_600px.jpg",
                    Order = 3,
                    ProductId = new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("e1a7b4c2-6d9f-4a83-8c5e-3b2d7a9f1c93"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/HJ5/HJ5178-001/images/thumbs_600/HJ5178-001_3_600_600px.jpg",
                    Order = 4,
                    ProductId = new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10")
                }, //Shoes For Nike AirMax Done

                //T-Shirt Start
                new ProductImage()
                {
                    Id = Guid.Parse("9b2e6d4f-1a73-4c8e-b5d2-7f3a1c9e6d04"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382582-001/images/thumbs_600/1382582-001_600_600px.jpg",
                    Order = 5,
                    ProductId = new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("3c7a1f9e-5b2d-4a86-8e1c-2d9f7b3a6c15"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382582-001/images/thumbs_600/1382582-001_1_600_600px.jpg",
                    Order = 6,
                    ProductId = new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21")
                }, //T-Shirt Under Armour Launch Done

                //Start BagSack
                new ProductImage()
                {
                    Id = Guid.Parse("d2a7c5e1-4b9f-4a86-8c3d-6e1f2b7a9c26"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/JD9/JD9555/images/thumbs_600/JD9555_600_600px.jpg",
                    Order = 7,
                    ProductId = new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("5f3e1a7c-9d2b-4c88-a6f1-3b7e2d9c1a37"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/JD9/JD9555/images/thumbs_600/JD9555_2_600_600px.jpg",
                    Order = 8,
                    ProductId = new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("a9c2b7d4-6e1f-4a83-9f5c-2d3b7a1e8c48"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/JD9/JD9555/images/thumbs_600/JD9555_3_600_600px.jpg",
                    Order = 9,
                    ProductId = new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32")
                }, //BagSack Adidas Linear Done

                //Start Pants
                new ProductImage()
                {
                    Id = Guid.Parse("f1a9d3c7-6e2b-4a85-8c1f-3d7b9e2a5c61"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/II3/II3978-323/images/thumbs_600/II3978-323_600_600px.jpg",
                    Order = 10,
                    ProductId = new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("8e4b2a1d-7c9f-4a86-b3d5-1a2e7c9f6b72"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/II3/II3978-323/images/thumbs_600/II3978-323_1_600_600px.jpg",
                    Order = 11,
                    ProductId = new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("2a7c9e5d-3b1f-4a83-9d6e-5c2b7a1f8e83"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/II3/II3978-323/images/thumbs_600/II3978-323_3_600_600px.jpg",
                    Order = 12,
                    ProductId = new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43")
                }, //Pants Nike Offline Chill Done


                //Start Sweatshirt
                new ProductImage()
                {
                    Id = Guid.Parse("c4a7e2b1-9d3f-4a86-8c5e-2f1b7a9d6c94"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/137/1374889-696/images/thumbs_600/1374889-696_600_600px.jpg",
                    Order = 13,
                    ProductId = new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("7d1b3c9e-5a2f-4a83-b6e1-9c7a2d5f8e05"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/137/1374889-696/images/thumbs_600/1374889-696_1_600_600px.jpg",
                    Order = 14,
                    ProductId = new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("1f9c2a7d-3e5b-4a88-8d1f-6b2c7e9a3d16"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/137/1374889-696/images/thumbs_600/1374889-696_2_600_600px.jpg",
                    Order = 15,
                    ProductId = new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("e7a3d1c5-8b2f-4a84-9c6e-3f1a7d2b5c27"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/137/1374889-696/images/thumbs_600/1374889-696_3_600_600px.jpg",
                    Order = 16,
                    ProductId = new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54")
                }, //End of Sweatshirt Under Armour Unstoppable


                //Start of Under Armour Matching Shorts
                new ProductImage()
                {
                    Id = Guid.Parse("3a9f7c2e-6d14-4b8a-9c5e-1f2d7a8b6c91"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382641-001/images/thumbs_600/1382641-001_600_600px.jpg",
                    Order = 17,
                    ProductId = new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("b5e1a9d3-2c74-4f6b-8a3d-9e7c1f2a6b04"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382641-001/images/thumbs_600/1382641-001_1_600_600px.jpg",
                    Order = 18,
                    ProductId = new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("7c2d8a1e-5f93-4a6b-b9c1-3e7f2a4d8c56"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382641-001/images/thumbs_600/1382641-001_2_600_600px.jpg",
                    Order = 19,
                    ProductId = new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62")
                }, //End of Under Armour Matching Shorts


                //Start of Nike Sport Essentials Jordan
                new ProductImage()
                {
                    Id = Guid.Parse("c9e4a7d2-1b83-4f6a-9c5d-2e7a1f8b3d64"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/IF2/IF2160-010/images/thumbs_600/IF2160-010_600_600px.jpg",
                    Order = 20,
                    ProductId = new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73")
                },

                new ProductImage()
                {
                    Id = Guid.Parse("4b7f2c9e-6a15-4d8b-b3c1-9e2a7f5d8c73"),
                    ImageUrl = "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/IF2/IF2160-010/images/thumbs_600/IF2160-010_1_600_600px.jpg",
                    Order = 21,
                    ProductId = new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73")
                } //End of Nike Sport Essentials Jordan
            };
            return productImages;
        }
    }
}
