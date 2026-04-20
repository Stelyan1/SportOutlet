using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportOutlet.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identifier"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false, comment: "Name"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Brand Image")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identifier"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false, comment: "Name"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Category Image")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identifier"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false, comment: "Name"),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Successor of category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identifier"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Name"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price"),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false, comment: "Description"),
                    Gender = table.Column<int>(type: "int", nullable: false, comment: "Sizing"),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "SubCategoryBelonging"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Hiding when out of stock"),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "BrandBelonging")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identification"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Image"),
                    Order = table.Column<int>(type: "int", nullable: false, comment: "Should have order to prevent chaos"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Belongs to a product")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identification"),
                    Key = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Material type"),
                    Value = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Is for product")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identification"),
                    Size = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Size"),
                    Stock = table.Column<int>(type: "int", nullable: false, comment: "Stock"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "For a product")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("8a1d4f72-2c6b-4e90-b3f7-1d5c9a8e4b21"), "https://icon2.cleanpng.com/20180528/koj/kisspng-under-armour-hoodie-logo-clothing-armour-5b0c22193ae282.2688990715275218172412.jpg", "Under Armour" },
                    { new Guid("c3f9a2e1-7b4d-4c9a-9f2e-6a8d1b3c5e7f"), "https://i0.wp.com/stickeri.eu/wp-content/uploads/2022/06/nike-500-dark.jpg?fit=500%2C500&ssl=1", "Nike" },
                    { new Guid("f7c2b9d4-6e3a-4a1f-8c5d-9e2b7f0a6c13"), "https://upload.wikimedia.org/wikipedia/commons/2/20/Adidas_Logo.svg", "Adidas" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55"), "https://i1.adis.ws/i/jpl/jd_IB4392010_al?w=363&h=363&qlt=90&bg=%23eaeaea", "Equipment" },
                    { new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33"), "https://www.buzzsneakers.bg/files/thumbs/files/images/slike-proizvoda/media/CW2/CW2288-001/images/thumbs_350/CW2288-001_350_350px.jpg", "Shoes" },
                    { new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"), "https://static.nike.com/a/images/t_web_pdp_936_v2/f_auto,u_9ddf04c7-2a9a-4d76-add1-d15af8f0263d,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/0cc486f3-e21f-481d-9da5-f897d76a22c1/M+NK+TCH+FLC+JGGR.png", "Clothes" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("1a7f3c5e-9d24-4b8a-a1f6-3e9c2d7b6a11"), new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33"), "Sneakers" },
                    { new Guid("3e9a1b6c-5d72-4f8a-b3c1-7a2d9e4f6b33"), new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33"), "Lifestyle sneakers" },
                    { new Guid("6b1d9a4f-3e7c-4a82-b5d1-8f2e6c9a0b66"), new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"), "Sweatshirts" },
                    { new Guid("7d2c4e1a-8b9f-4a63-a2e5-1c7b3d9f0a44"), new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"), "T-Shirts" },
                    { new Guid("8e5a2c7d-9f1b-4a6e-b3d8-6c2f0a1e9b88"), new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55"), "Socks" },
                    { new Guid("a9e3b7d2-1c5f-4b8a-9d6e-2f7c1a3b8e55"), new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"), "Shorts" },
                    { new Guid("b4c2d8f1-6a93-4e7b-9f0a-5c1d2e8f7a22"), new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33"), "Running Shoes" },
                    { new Guid("c2f7e1a9-4b6d-4d83-a8c5-3e1b9f7a2c77"), new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"), "Pants" },
                    { new Guid("d9f4b2a1-6c7e-4a83-b5d9-2f1c8e7a3b99"), new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55"), "Bags and Sacks" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Gender", "IsActive", "Name", "Price", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54"), new Guid("8a1d4f72-2c6b-4e90-b3f7-1d5c9a8e4b21"), "When cold, wet weather won't stop your workout, this Under Armour Unstoppable Men's Jacket is the choice for you. Ultra-light and stretchy, it repels rain, keeps you warm (but not too hot), and moves with you through every workout.\r\n\r\n\r\nDetails:\r\nStretchy woven fabric is strong yet lightweight for durability and comfort\r\n4-way stretch material moves better in every direction for unrestricted movement\r\nWater-repellent coating helps you stay dry in wet conditions\r\nSecure zippered hand pockets keep your essentials safe. Bungee cord hem adjusts for a secure, personalized fit.", 1, true, "Under Armour Unstoppable", 53.68m, new Guid("6b1d9a4f-3e7c-4a82-b5d1-8f2e6c9a0b66") },
                    { new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10"), new Guid("c3f9a2e1-7b4d-4c9a-9f2e-6a8d1b3c5e7f"), "The Nike Air Max Pulse Men's Shoe combines London-inspired style with enhanced point-loaded Air cushioning for a fresh look and better performance.\r\n\r\n\r\nDetails\r\nPoint-load cushioning system features a plastic clip that distributes weight to targeted points in the Air module, providing a unique, springy feel\r\nPerformance comfort, reimagined for the street\r\nFoam midsole\r\nRubber outsole", 0, true, "Nike Air Max Pulse", 125.25m, new Guid("1a7f3c5e-9d24-4b8a-a1f6-3e9c2d7b6a11") },
                    { new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32"), new Guid("f7c2b9d4-6e3a-4a1f-8c5d-9e2b7f0a6c13"), "With this adidas Linear training bag you will stay organized while you are on the go.\r\n\r\n\r\nDetails\r\nDimensions: 22 cm x 56 cm x 28 cm\r\nVolume: 39.75 l\r\nSide and end pockets with zipper\r\nInternal zip pockets\r\nSeparate shoe compartment\r\nAdjustable shoulder strap with removable padding\r\nTwo padded carrying handles\r\n\r\nEco Story\r\nThis product is made from 50% recycled materials", 2, true, "adidas Linear", 24.69m, new Guid("d9f4b2a1-6c7e-4a83-b5d9-2f1c8e7a3b99") },
                    { new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21"), new Guid("8a1d4f72-2c6b-4e90-b3f7-1d5c9a8e4b21"), "Longer distances and faster runs start with maximum comfort. The Under Armour Launch Men's Running T-Shirt is soft, stretchy and so lightweight it feels like you're wearing nothing.\r\n\r\n\r\nDetail:\r\nSoft, lightweight and breathable fabric designed for complete comfort on every run\r\nMoisture-wicking and quick-drying fabric\r\nOverlapping detail improves ventilation for better airflow\r\nReflective details improve visibility in low light\r\nOdor control technology helps you stay fresh\r\nMaterial: 94% polyester, 6% polyester", 0, true, "Under Armour Launch", 27.99m, new Guid("7d2c4e1a-8b9f-4a63-a2e5-1c7b3d9f0a44") },
                    { new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43"), new Guid("c3f9a2e1-7b4d-4c9a-9f2e-6a8d1b3c5e7f"), "The Nike Offline Chill Women's Pants are designed for everyday comfort and a casual style.\r\n\r\n\r\nDetails\r\nLightweight French terry fabric combines the feel of fleece and jersey knitwear\r\nLoose fit makes movement easier\r\nEmbroidered Swoosh logo adds a subtle, recognizable accent\r\nPadded elastic waistband with internal drawcord ensures a secure fit\r\nPin tuck details add an elegant tailoring accent\r\nSide seam pockets hold small essentials\r\nOpen hem creates a relaxed silhouette\r\nFabric: 70% cotton, 30% polyester", 1, true, "Nike Offline Chill", 64.99m, new Guid("c2f7e1a9-4b6d-4d83-a8c5-3e1b9f7a2c77") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "Order", "ProductId" },
                values: new object[,]
                {
                    { new Guid("1f9c2a7d-3e5b-4a88-8d1f-6b2c7e9a3d16"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/137/1374889-696/images/thumbs_600/1374889-696_2_600_600px.jpg", 15, new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54") },
                    { new Guid("2a7c9e5d-3b1f-4a83-9d6e-5c2b7a1f8e83"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/II3/II3978-323/images/thumbs_600/II3978-323_3_600_600px.jpg", 12, new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43") },
                    { new Guid("2d8c5a7e-1f3b-4a9c-b6d2-9e7a1c3f8b82"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/HJ5/HJ5178-001/images/thumbs_600/HJ5178-001_2_600_600px.jpg", 3, new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10") },
                    { new Guid("3c7a1f9e-5b2d-4a86-8e1c-2d9f7b3a6c15"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382582-001/images/thumbs_600/1382582-001_1_600_600px.jpg", 6, new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21") },
                    { new Guid("5f3e1a7c-9d2b-4c88-a6f1-3b7e2d9c1a37"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/JD9/JD9555/images/thumbs_600/JD9555_2_600_600px.jpg", 8, new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32") },
                    { new Guid("6c2f9e1a-3b7d-4a85-9f2c-8d1e7b3a5c60"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/HJ5/HJ5178-001/images/thumbs_600/HJ5178-001_600_600px.jpg", 1, new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10") },
                    { new Guid("7d1b3c9e-5a2f-4a83-b6e1-9c7a2d5f8e05"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/137/1374889-696/images/thumbs_600/1374889-696_1_600_600px.jpg", 14, new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54") },
                    { new Guid("8e4b2a1d-7c9f-4a86-b3d5-1a2e7c9f6b72"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/II3/II3978-323/images/thumbs_600/II3978-323_1_600_600px.jpg", 11, new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43") },
                    { new Guid("9b2e6d4f-1a73-4c8e-b5d2-7f3a1c9e6d04"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/138/1382582-001/images/thumbs_600/1382582-001_600_600px.jpg", 5, new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21") },
                    { new Guid("a9c2b7d4-6e1f-4a83-9f5c-2d3b7a1e8c48"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/JD9/JD9555/images/thumbs_600/JD9555_3_600_600px.jpg", 9, new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32") },
                    { new Guid("b7a1d3c9-5e2f-4d88-a6c4-2f9e1b7a3d71"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/HJ5/HJ5178-001/images/thumbs_600/HJ5178-001_1_600_600px.jpg", 2, new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10") },
                    { new Guid("c4a7e2b1-9d3f-4a86-8c5e-2f1b7a9d6c94"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/137/1374889-696/images/thumbs_600/1374889-696_600_600px.jpg", 13, new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54") },
                    { new Guid("d2a7c5e1-4b9f-4a86-8c3d-6e1f2b7a9c26"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/JD9/JD9555/images/thumbs_600/JD9555_600_600px.jpg", 7, new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32") },
                    { new Guid("e1a7b4c2-6d9f-4a83-8c5e-3b2d7a9f1c93"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/HJ5/HJ5178-001/images/thumbs_600/HJ5178-001_3_600_600px.jpg", 4, new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10") },
                    { new Guid("e7a3d1c5-8b2f-4a84-9c6e-3f1a7d2b5c27"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/137/1374889-696/images/thumbs_600/1374889-696_3_600_600px.jpg", 16, new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54") },
                    { new Guid("f1a9d3c7-6e2b-4a85-8c1f-3d7b9e2a5c61"), "https://www.sportvision.bg/files/thumbs/files/images/slike_proizvoda/media/II3/II3978-323/images/thumbs_600/II3978-323_600_600px.jpg", 10, new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43") }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "Id", "Key", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("2b9e5a7c-1d3f-4a84-8c2e-6f7a1b9d3c61"), "Color", new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43"), "Green" },
                    { new Guid("6e2b7a1d-9c3f-4a83-b5d1-2f8a7c9e4d49"), "Color", new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21"), "Black" },
                    { new Guid("a1c5e9d2-7b3f-4a86-8d1c-9e2f7b3a6c38"), "Color", new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10"), "Black" },
                    { new Guid("d3a7c1e9-5b2f-4a88-9c6e-7d1a2b3f8c50"), "Color", new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32"), "Black" },
                    { new Guid("f8c1a3d7-6e2b-4a85-9d5f-3b7a2c1e8d72"), "Color", new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54"), "Pink" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "ProductId", "Size", "Stock" },
                values: new object[,]
                {
                    { new Guid("1c9e7a2d-3b5f-4a85-9d1e-6a7c2b3f8e27"), new Guid("7b3e1f9a-2c6d-4a85-b8f0-5d2c9e7a1b32"), "Adjustable", 20 },
                    { new Guid("2e7c1a5d-9b3f-4a83-8d6e-1c2f7a9b3d50"), new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54"), "S", 20 },
                    { new Guid("3f2a9c1e-7d5b-4a86-8c1f-9b2e7a3d6c83"), new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10"), "44.5", 20 },
                    { new Guid("6a2d3f9c-1e7b-4a86-8c5f-3d1b7a9e2c38"), new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43"), "S", 20 },
                    { new Guid("8c5a1d7e-2f3b-4a83-b9d1-7e6a2c3f1b05"), new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21"), "L", 20 },
                    { new Guid("9d1a3c7f-5b2e-4a88-9c6d-2f7a1e3b8c61"), new Guid("1e9b3c7d-4a2f-4d86-b5c1-8a7e2d6f9c54"), "M", 20 },
                    { new Guid("b1e7d3a9-5c2f-4a84-9d6e-2a3f7c1b8d94"), new Guid("4f1c7a2e-8b93-4d6f-a5e1-2c9d7b3a6f10"), "45", 20 },
                    { new Guid("d7a3c1f9-6b2e-4a88-8c5d-1f9e2b3a7c16"), new Guid("a2d9e6c4-5b71-4f8a-9c3d-7e1b2f6a8c21"), "XL", 20 },
                    { new Guid("f3b1a7c9-2d5e-4a84-b6c1-8e7a3d2f9c49"), new Guid("c8a2d5f1-9e47-4b6c-a3f8-1d7b2c9e6a43"), "M", 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_ProductId",
                table: "ProductSpecifications",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductSpecifications");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
