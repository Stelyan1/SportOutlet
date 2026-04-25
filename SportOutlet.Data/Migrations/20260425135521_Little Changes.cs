using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportOutlet.Data.Migrations
{
    /// <inheritdoc />
    public partial class LittleChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Identification of image"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Url of the image"),
                    Gender = table.Column<int>(type: "int", nullable: false, comment: "Example for man or women category"),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "From where we get to which category it belongs")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryImages_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryImages",
                columns: new[] { "Id", "CategoryId", "Gender", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("2c8f5a1e-9d47-4b6a-8e2c-7a1d3f9b6c92"), new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33"), 3, "https://todaysparent.mblycdn.com/tp/resized/2024/06/1600x1200/The-Best-Nike-Shoes-for-Kids-2024.png" },
                    { new Guid("5d4a9c2e-8f31-4b6a-a7d2-1c9e5f3b7a69"), new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33"), 1, "https://i8.amplience.net/s/scvl/178735_396397_SET/1?fmt=auto" },
                    { new Guid("7a2f6c9e-5d81-4a3b-b8c4-9e1f2d7a6b58"), new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55"), 0, "https://i1.adis.ws/i/jpl/jd_IB4392010_al?w=363&h=363&qlt=90&bg=%23eaeaea" },
                    { new Guid("8f2c6a1d-7b93-4a5e-b9c1-3d7a2e6f5b81"), new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55"), 1, "https://images.asos-media.com/products/nike-everyday-plus-cushioned-frilly-sock-in-lilac/201059358-1-lilac?$n_750w$&wid=750&hei=750&fit=crop" },
                    { new Guid("91c5d8a3-2e47-4b6f-8a9c-3f1e7d2b6a34"), new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"), 0, "https://static.nike.com/a/images/t_web_pdp_936_v2/f_auto,u_9ddf04c7-2a9a-4d76-add1-d15af8f0263d,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/0cc486f3-e21f-481d-9da5-f897d76a22c1/M+NK+TCH+FLC+JGGR.png" },
                    { new Guid("9e3b7c2a-5d81-4a6f-b8c4-1f2d7a9c6b14"), new Guid("2f8d1a6b-5c3e-4b9f-a7d2-6e0c4a1b9d55"), 3, "https://static.nike.com/a/images/t_web_pw_592_v2/f_auto/u_9ddf04c7-2a9a-4d76-add1-d15af8f0263d,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/4018511d-ba37-4f07-9dfe-7bbb2e8ee61a/UPF+40%2B+INFANT+BUCKET+HAT.png" },
                    { new Guid("b6a1d9e3-4c82-4f7b-a5d1-8c3e2a7f9d03"), new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"), 3, "https://images.prodirectsport.com/ProductImages/Main/420123_Main_Thumb_1699808.jpg" },
                    { new Guid("c1b7e4a9-3d82-4f6c-9a5e-2b7d1f8c6a70"), new Guid("9c4b7f21-6a8e-4c3d-b2f9-0d1a5e7c8b44"), 1, "https://nikestrength.com/cdn/shop/files/BLK-PHOENIX-CREWNECK-WOMENS-FRONT_533x.jpg?v=1762461327" },
                    { new Guid("e3b7a9d1-4c82-4f6a-9b1d-7c2a5e8f9012"), new Guid("5e2a9c1d-3f7b-4d8e-a6c2-1b9f0e4d7a33"), 0, "https://www.buzzsneakers.bg/files/thumbs/files/images/slike-proizvoda/media/CW2/CW2288-001/images/thumbs_350/CW2288-001_350_350px.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryImages_CategoryId",
                table: "CategoryImages",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryImages");
        }
    }
}
