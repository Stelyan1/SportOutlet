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
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(sc => sc.Id);

            builder.Property(sc => sc.Name)
                   .HasMaxLength(120)
                   .IsRequired();

            builder.HasOne(sc => sc.Category)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(sc => sc.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(SeedSubCategories());
        }

        private IEnumerable<SubCategory> SeedSubCategories()
        {
            IEnumerable<SubCategory> subCategories = new List<SubCategory>()
            {
                new SubCategory()
                {
                    Id = Guid.Parse("1a7f3c5e-9d24-4b8a-a1f6-3e9c2d7b6a11"),
                    Name = "Sneakers",
                    CategoryId = new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33")
                },

                new SubCategory()
                {
                    Id = Guid.Parse("b4c2d8f1-6a93-4e7b-9f0a-5c1d2e8f7a22"),
                    Name = "Running Shoes",
                    CategoryId = new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33")
                },

                new SubCategory()
                {
                    Id = Guid.Parse("3e9a1b6c-5d72-4f8a-b3c1-7a2d9e4f6b33"),
                    Name = "Lifestyle sneakers",
                    CategoryId = new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33")
                },

                new SubCategory()
                {
                    Id = Guid.Parse("7d2c4e1a-8b9f-4a63-a2e5-1c7b3d9f0a44"),
                    Name = "T-Shirts",
                    CategoryId = new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44")
                },

                new SubCategory()
                {
                    Id = Guid.Parse("a9e3b7d2-1c5f-4b8a-9d6e-2f7c1a3b8e55"),
                    Name = "Shorts",
                    CategoryId = new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44")
                },

                new SubCategory()
                {
                    Id = Guid.Parse("6b1d9a4f-3e7c-4a82-b5d1-8f2e6c9a0b66"),
                    Name = "Sweatshirts",
                    CategoryId = new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44")
                },

                new SubCategory()
                {
                    Id = Guid.Parse("c2f7e1a9-4b6d-4d83-a8c5-3e1b9f7a2c77"),
                    Name = "Pants",
                    CategoryId = new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44")
                },

                new SubCategory()
                {
                    Id = Guid.Parse("8e5a2c7d-9f1b-4a6e-b3d8-6c2f0a1e9b88"),
                    Name = "Socks",
                    CategoryId = new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55")
                },

                new SubCategory()
                {
                    Id = Guid.Parse("d9f4b2a1-6c7e-4a83-b5d9-2f1c8e7a3b99"),
                    Name = "Bags and Sacks",
                    CategoryId = new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55")
                }
            };

            return subCategories;
        }
    }
}
