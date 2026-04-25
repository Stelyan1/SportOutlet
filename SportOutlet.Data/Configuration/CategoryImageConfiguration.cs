using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportOutlet.Data.Models;
using SportOutlet.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Configuration
{
    public class CategoryImageConfiguration : IEntityTypeConfiguration<CategoryImage>
    {
        public void Configure(EntityTypeBuilder<CategoryImage> builder)
        {
            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.ImageUrl)
                   .IsRequired();

            builder.HasOne(ci => ci.Category)
                   .WithMany(c => c.CategoryImages)
                   .HasForeignKey(ci => ci.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(SeedCategoryImages());

        }

        private IEnumerable<CategoryImage> SeedCategoryImages()
        {
            IEnumerable<CategoryImage> categoryImages = new List<CategoryImage>()
            {
                //Men Shoes
                new CategoryImage()
                {
                    Id = Guid.Parse("e3b7a9d1-4c82-4f6a-9b1d-7c2a5e8f9012"),
                    ImageUrl = "https://www.buzzsneakers.bg/files/thumbs/files/images/slike-proizvoda/media/CW2/CW2288-001/images/thumbs_350/CW2288-001_350_350px.jpg",
                    Gender = Gender.Man,
                    CategoryId = new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33")
                },

                //Men Clothes
                new CategoryImage()
                {
                    Id = Guid.Parse("91c5d8a3-2e47-4b6f-8a9c-3f1e7d2b6a34"),
                    ImageUrl = "https://static.nike.com/a/images/t_web_pdp_936_v2/f_auto,u_9ddf04c7-2a9a-4d76-add1-d15af8f0263d,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/0cc486f3-e21f-481d-9da5-f897d76a22c1/M+NK+TCH+FLC+JGGR.png",
                    Gender = Gender.Man,
                    CategoryId = new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44")
                },

                //Men Equipment
                new CategoryImage()
                {
                    Id = Guid.Parse("7a2f6c9e-5d81-4a3b-b8c4-9e1f2d7a6b58"),
                    ImageUrl = "https://i1.adis.ws/i/jpl/jd_IB4392010_al?w=363&h=363&qlt=90&bg=%23eaeaea",
                    Gender = Gender.Man,
                    CategoryId = new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55")
                },

                //Woman Shoes
                new CategoryImage()
                {
                    Id = Guid.Parse("5d4a9c2e-8f31-4b6a-a7d2-1c9e5f3b7a69"),
                    ImageUrl = "https://i8.amplience.net/s/scvl/178735_396397_SET/1?fmt=auto",
                    Gender = Gender.Woman,
                    CategoryId = new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33")
                },


                //Woman Clothes
                new CategoryImage()
                {
                    Id = Guid.Parse("c1b7e4a9-3d82-4f6c-9a5e-2b7d1f8c6a70"),
                    ImageUrl = "https://nikestrength.com/cdn/shop/files/BLK-PHOENIX-CREWNECK-WOMENS-FRONT_533x.jpg?v=1762461327",
                    Gender = Gender.Woman,
                    CategoryId = new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44")
                },


                //Woman Equipment
                new CategoryImage()
                {
                    Id = Guid.Parse("8f2c6a1d-7b93-4a5e-b9c1-3d7a2e6f5b81"),
                    ImageUrl = "https://images.asos-media.com/products/nike-everyday-plus-cushioned-frilly-sock-in-lilac/201059358-1-lilac?$n_750w$&wid=750&hei=750&fit=crop",
                    Gender = Gender.Woman,
                    CategoryId = new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55")
                },

                
                //Kids Shoes
                new CategoryImage()
                {
                    Id = Guid.Parse("2c8f5a1e-9d47-4b6a-8e2c-7a1d3f9b6c92"),
                    ImageUrl = "https://todaysparent.mblycdn.com/tp/resized/2024/06/1600x1200/The-Best-Nike-Shoes-for-Kids-2024.png",
                    Gender = Gender.Kids,
                    CategoryId = new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33")
                },


                //Kids Clothes
                new CategoryImage()
                {
                    Id = Guid.Parse("b6a1d9e3-4c82-4f7b-a5d1-8c3e2a7f9d03"),
                    ImageUrl = "https://images.prodirectsport.com/ProductImages/Main/420123_Main_Thumb_1699808.jpg",
                    Gender = Gender.Kids,
                    CategoryId = new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44")
                },


                //Kids Equipment
                new CategoryImage()
                {
                    Id = Guid.Parse("9e3b7c2a-5d81-4a6f-b8c4-1f2d7a9c6b14"),
                    ImageUrl = "https://static.nike.com/a/images/t_web_pw_592_v2/f_auto/u_9ddf04c7-2a9a-4d76-add1-d15af8f0263d,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/4018511d-ba37-4f07-9dfe-7bbb2e8ee61a/UPF+40%2B+INFANT+BUCKET+HAT.png",
                    Gender = Gender.Kids,
                    CategoryId = new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55")
                }

            };

            return categoryImages;
        }
    }
}
