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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .HasMaxLength(120)
                   .IsRequired();

            builder.Property(b => b.ImageUrl)
                   .IsRequired();

            builder.HasData(SeedBrands());
        }

        private IEnumerable<Brand> SeedBrands()
        {
            IEnumerable<Brand> brands = new List<Brand>()
            {
                new Brand()
                {
                    Id = Guid.Parse("c3f9a2e1-7b4d-4c9a-9f2e-6a8d1b3c5e7f"),
                    Name = "Nike",
                    ImageUrl = "https://i0.wp.com/stickeri.eu/wp-content/uploads/2022/06/nike-500-dark.jpg?fit=500%2C500&ssl=1"
                },

                new Brand()
                {
                    Id = Guid.Parse("8a1d4f72-2c6b-4e90-b3f7-1d5c9a8e4b21"),
                    Name = "Under Armour",
                    ImageUrl = "https://icon2.cleanpng.com/20180528/koj/kisspng-under-armour-hoodie-logo-clothing-armour-5b0c22193ae282.2688990715275218172412.jpg"
                },

                new Brand()
                {
                    Id = Guid.Parse("f7c2b9d4-6e3a-4a1f-8c5d-9e2b7f0a6c13"),
                    Name = "Adidas",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/20/Adidas_Logo.svg"
                }
            };

            return brands;
        }
    }
}
