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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(p => p.Price)
                  .HasPrecision(18, 2)
                  .IsRequired();

            builder.Property(p => p.Description)
                   .HasMaxLength(2000)
                   .IsRequired();

            builder.Property(p => p.IsActive)
                   .HasDefaultValue(true);

            builder.HasData(SeedProducts());
        }

        private IEnumerable<Product> SeedProducts()
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.Parse("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10"),
                    Name = "Nike Air Max Pulse", //Shoes
                    BrandId = new Guid("c3f9a2e1-7b4d-4c9a-9f2e-6a8d1b3c5e7f"),
                    SubCategoryId = new Guid("1a7f3c5e-9d24-4b8a-a1f6-3e9c2d7b6a11"),
                    Price = new Decimal(125.25),
                    Description = "The Nike Air Max Pulse Men's Shoe combines London-inspired style with enhanced point-loaded Air cushioning for a fresh look and better performance.\r\n\r\n\r\nDetails\r\nPoint-load cushioning system features a plastic clip that distributes weight to targeted points in the Air module, providing a unique, springy feel\r\nPerformance comfort, reimagined for the street\r\nFoam midsole\r\nRubber outsole",
                    Gender = Gender.Man,
                    IsActive = true
                },

                new Product()
                {
                    Id = Guid.Parse("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21"),
                    Name = "Under Armour Launch", //T-Shirt
                    BrandId = new Guid("8a1d4f72-2c6b-4e90-b3f7-1d5c9a8e4b21"),
                    SubCategoryId =new Guid("7d2c4e1a-8b9f-4a63-a2e5-1c7b3d9f0a44"),
                    Price = new Decimal(27.99),
                    Description = "Longer distances and faster runs start with maximum comfort. The Under Armour Launch Men's Running T-Shirt is soft, stretchy and so lightweight it feels like you're wearing nothing.\r\n\r\n\r\nDetail:\r\nSoft, lightweight and breathable fabric designed for complete comfort on every run\r\nMoisture-wicking and quick-drying fabric\r\nOverlapping detail improves ventilation for better airflow\r\nReflective details improve visibility in low light\r\nOdor control technology helps you stay fresh\r\nMaterial: 94% polyester, 6% polyester",
                    Gender = Gender.Man,
                    IsActive = true
                },

                new Product()
                {
                    Id = Guid.Parse("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32"),
                    Name = "adidas Linear",  //BagSack
                    BrandId = new Guid("f7c2b9d4-6e3a-4a1f-8c5d-9e2b7f0a6c13"),
                    SubCategoryId =new Guid("d9f4b2a1-6c7e-4a83-b5d9-2f1c8e7a3b99"),
                    Price = new Decimal(24.69),
                    Description = "With this adidas Linear training bag you will stay organized while you are on the go.\r\n\r\n\r\nDetails\r\nDimensions: 22 cm x 56 cm x 28 cm\r\nVolume: 39.75 l\r\nSide and end pockets with zipper\r\nInternal zip pockets\r\nSeparate shoe compartment\r\nAdjustable shoulder strap with removable padding\r\nTwo padded carrying handles\r\n\r\nEco Story\r\nThis product is made from 50% recycled materials",
                    Gender = Gender.Unisex,
                    IsActive = true
                },

                new Product()
                {
                    Id = Guid.Parse("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43"),
                    Name = "Nike Offline Chill", //Pants
                    BrandId = new Guid("c3f9a2e1-7b4d-4c9a-9f2e-6a8d1b3c5e7f"),
                    SubCategoryId =new Guid("c2f7e1a9-4b6d-4d83-a8c5-3e1b9f7a2c77"),
                    Price = new Decimal(64.99),
                    Description = "The Nike Offline Chill Women's Pants are designed for everyday comfort and a casual style.\r\n\r\n\r\nDetails\r\nLightweight French terry fabric combines the feel of fleece and jersey knitwear\r\nLoose fit makes movement easier\r\nEmbroidered Swoosh logo adds a subtle, recognizable accent\r\nPadded elastic waistband with internal drawcord ensures a secure fit\r\nPin tuck details add an elegant tailoring accent\r\nSide seam pockets hold small essentials\r\nOpen hem creates a relaxed silhouette\r\nFabric: 70% cotton, 30% polyester",
                    Gender = Gender.Woman,
                    IsActive = true
                },

                new Product()
                {
                    Id = Guid.Parse("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54"),
                    Name = "Under Armour Unstoppable", //Sweatshirt
                    BrandId = new Guid("8a1d4f72-2c6b-4e90-b3f7-1d5c9a8e4b21"),
                    SubCategoryId =new Guid("6b1d9a4f-3e7c-4a82-b5d1-8f2e6c9a0b66"),
                    Price = new Decimal(53.68),
                    Description = "When cold, wet weather won't stop your workout, this Under Armour Unstoppable Men's Jacket is the choice for you. Ultra-light and stretchy, it repels rain, keeps you warm (but not too hot), and moves with you through every workout.\r\n\r\n\r\nDetails:\r\nStretchy woven fabric is strong yet lightweight for durability and comfort\r\n4-way stretch material moves better in every direction for unrestricted movement\r\nWater-repellent coating helps you stay dry in wet conditions\r\nSecure zippered hand pockets keep your essentials safe. Bungee cord hem adjusts for a secure, personalized fit.",
                    Gender= Gender.Woman,
                    IsActive = true    
                },

                new Product()
                {
                    Id = Guid.Parse("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62"),
                    Name = "Under Armour Launch 7'' 2-in-1",   //Man Shorts Match Under Armour T-Shirt
                    BrandId = new Guid("8a1d4f72-2c6b-4e90-b3f7-1d5c9a8e4b21"),
                    SubCategoryId = new Guid("a9e3b7d2-1c5f-4b8a-9d6e-2f7c1a3b8e55"),
                    Price = new Decimal(49.99),
                    Description = "Stay light, supported and ready to move with the Under Armour Launch 7'' 2-in-1 Men's Running Shorts, designed to provide comfort, breathability and high performance on every run.\r\n\r\n\r\nDetails\r\nLightweight woven outer shorts provide comfort and durability\r\nBuilt-in knit compression shorts give extra coverage and support\r\nSweat-wicking fabric dries quickly to keep you dry and comfortable\r\nHighly breathable mesh panels enhance ventilation\r\nSoft knit waistband with internal drawcord provides a secure and comfortable fit\r\nOpen hand pockets include an internal phone pocket on the right\r\n\r\nEco story\r\nThe main fabric contains at least 90% recycled polyester, excluding finishing and decorative elements, to reduce waste and carbon emissions.",
                    Gender = Gender.Man,
                    IsActive = true
                },

                new Product()
                {
                    Id = Guid.Parse("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73"),
                    Name = "Nike Sportswear Jordan", //Nike Similar Shorts to Under Armour Shorts
                    BrandId = new Guid("c3f9a2e1-7b4d-4c9a-9f2e-6a8d1b3c5e7f"),
                    SubCategoryId =new Guid("a9e3b7d2-1c5f-4b8a-9d6e-2f7c1a3b8e55"),
                    Price = new Decimal(39.99),
                    Description = "These Jordan Sport Essentials Men's Woven Shorts with Dri-FIT are called Essentials for a reason. They're made with a four-way stretch woven fabric and sweat-wicking technology to help keep you comfortable on and off the court.\r\n\r\n\r\nDetails\r\nNike Dri-FIT technology wicks sweat away from the skin for faster evaporation, helping you stay dry and comfortable\r\nSide pockets for storing your small items\r\nMain: 88% polyester/12% elastane. Mesh: 100% polyester\r\nMachine wash\r\n\r\nEco story This product is made with recycled materials",
                    Gender = Gender.Man,
                    IsActive = true
                }
            };
            return products;
        }
    }
}
