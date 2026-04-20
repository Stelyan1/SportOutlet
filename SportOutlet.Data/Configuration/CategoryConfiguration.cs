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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                   .HasMaxLength(120)
                   .IsRequired();

            builder.Property(c => c.ImageUrl)
                   .IsRequired();

            builder.HasData(SeedCategories());
        }

        private IEnumerable<Category> SeedCategories()
        {
            IEnumerable<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = Guid.Parse("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33"),
                    Name = "Shoes",
                    ImageUrl = "https://www.buzzsneakers.bg/files/thumbs/files/images/slike-proizvoda/media/CW2/CW2288-001/images/thumbs_350/CW2288-001_350_350px.jpg"
                },

                new Category()
                {
                    Id = Guid.Parse("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"),
                    Name = "Clothes",
                    ImageUrl = "https://static.nike.com/a/images/t_web_pdp_936_v2/f_auto,u_9ddf04c7-2a9a-4d76-add1-d15af8f0263d,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/0cc486f3-e21f-481d-9da5-f897d76a22c1/M+NK+TCH+FLC+JGGR.png"
                },

                new Category()
                {
                    Id = Guid.Parse("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55"),
                    Name = "Equipment",
                    ImageUrl = "https://i1.adis.ws/i/jpl/jd_IB4392010_al?w=363&h=363&qlt=90&bg=%23eaeaea"
                }
            };
            return categories;
        }
    }
}
