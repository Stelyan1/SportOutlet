using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportOutlet.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addednewclothes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Gender", "IsActive", "Name", "Price", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73"), new Guid("c3f9a2e1-7b4d-4c9a-9f2e-6a8d1b3c5e7f"), "These Jordan Sport Essentials Men's Woven Shorts with Dri-FIT are called Essentials for a reason. They're made with a four-way stretch woven fabric and sweat-wicking technology to help keep you comfortable on and off the court.\r\n\r\n\r\nDetails\r\nNike Dri-FIT technology wicks sweat away from the skin for faster evaporation, helping you stay dry and comfortable\r\nSide pockets for storing your small items\r\nMain: 88% polyester/12% elastane. Mesh: 100% polyester\r\nMachine wash\r\n\r\nEco story This product is made with recycled materials", 0, true, "Nike Sportswear Jordan", 39.99m, new Guid("a9e3b7d2-1c5f-4b8a-9d6e-2f7c1a3b8e55") },
                    { new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62"), new Guid("8a1d4f72-2c6b-4e90-b3f7-1d5c9a8e4b21"), "Stay light, supported and ready to move with the Under Armour Launch 7'' 2-in-1 Men's Running Shorts, designed to provide comfort, breathability and high performance on every run.\r\n\r\n\r\nDetails\r\nLightweight woven outer shorts provide comfort and durability\r\nBuilt-in knit compression shorts give extra coverage and support\r\nSweat-wicking fabric dries quickly to keep you dry and comfortable\r\nHighly breathable mesh panels enhance ventilation\r\nSoft knit waistband with internal drawcord provides a secure and comfortable fit\r\nOpen hand pockets include an internal phone pocket on the right\r\n\r\nEco story\r\nThe main fabric contains at least 90% recycled polyester, excluding finishing and decorative elements, to reduce waste and carbon emissions.", 0, true, "Under Armour Launch 7'' 2-in-1", 49.99m, new Guid("a9e3b7d2-1c5f-4b8a-9d6e-2f7c1a3b8e55") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "Order", "ProductId" },
                values: new object[,]
                {
                    { new Guid("3a9f7c2e-6d14-4b8a-9c5e-1f2d7a8b6c91"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382641-001/images/thumbs_600/1382641-001_600_600px.jpg", 17, new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62") },
                    { new Guid("4b7f2c9e-6a15-4d8b-b3c1-9e2a7f5d8c73"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/IF2/IF2160-010/images/thumbs_600/IF2160-010_1_600_600px.jpg", 21, new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73") },
                    { new Guid("7c2d8a1e-5f93-4a6b-b9c1-3e7f2a4d8c56"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382641-001/images/thumbs_600/1382641-001_2_600_600px.jpg", 19, new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62") },
                    { new Guid("b5e1a9d3-2c74-4f6b-8a3d-9e7c1f2a6b04"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382641-001/images/thumbs_600/1382641-001_1_600_600px.jpg", 18, new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62") },
                    { new Guid("c9e4a7d2-1b83-4f6a-9c5d-2e7a1f8b3d64"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/IF2/IF2160-010/images/thumbs_600/IF2160-010_600_600px.jpg", 20, new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73") }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "Id", "Key", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("6f1a9c3e-2b74-4d8a-9c5e-1e7a3f8b6c92"), "Color", new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62"), "Black" },
                    { new Guid("d3b7e2a1-9c54-4f6a-8d1c-2a7f9e3b6c81"), "Color", new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73"), "Black" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "ProductId", "Size", "Stock" },
                values: new object[,]
                {
                    { new Guid("1d7a9c3e-5b24-4f6a-8c1d-2e9f7b3a6c85"), new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62"), "L", 20 },
                    { new Guid("5e3c1a7d-2f94-4b6a-9d1c-8a2e7f3b6c19"), new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73"), "L", 20 },
                    { new Guid("8b2f6d1c-9a73-4e5a-b4c2-7d1e3f9a6c08"), new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62"), "XL", 20 },
                    { new Guid("a2f9b6c3-4d71-4e8a-8c5d-3e7a1f2b9c60"), new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73"), "XL", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("3a9f7c2e-6d14-4b8a-9c5e-1f2d7a8b6c91"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("4b7f2c9e-6a15-4d8b-b3c1-9e2a7f5d8c73"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("7c2d8a1e-5f93-4a6b-b9c1-3e7f2a4d8c56"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("b5e1a9d3-2c74-4f6b-8a3d-9e7c1f2a6b04"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("c9e4a7d2-1b83-4f6a-9c5d-2e7a1f8b3d64"));

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: new Guid("6f1a9c3e-2b74-4d8a-9c5e-1e7a3f8b6c92"));

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "Id",
                keyValue: new Guid("d3b7e2a1-9c54-4f6a-8d1c-2a7f9e3b6c81"));

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: new Guid("1d7a9c3e-5b24-4f6a-8c1d-2e9f7b3a6c85"));

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: new Guid("5e3c1a7d-2f94-4b6a-9d1c-8a2e7f3b6c19"));

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: new Guid("8b2f6d1c-9a73-4e5a-b4c2-7d1e3f9a6c08"));

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: new Guid("a2f9b6c3-4d71-4e8a-8c5d-3e7a1f2b9c60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c9e7a1d-3b5f-4a82-b6c1-2d7f8e3a9b73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4a8c2d1-9b37-4e6f-a5c2-8d1e7b3f9a62"));
        }
    }
}
