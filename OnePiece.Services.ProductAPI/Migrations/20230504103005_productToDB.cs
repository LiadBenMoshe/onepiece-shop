using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnePiece.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class productToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Paramecia", " Devil Fruit that grants the user's body the properties of rubber, effectively turning them into a Rubber Human.", "https://onepieceshop.blob.core.windows.net/onepiece-products/Gomu_Gomu_no_Mi", "Gomo Gomo no Mi", 15.0 },
                    { 2, "Logia", "Devil Fruit that allows the user to create, control, and transform into fire at will..", "https://onepieceshop.blob.core.windows.net/onepiece-products/Mera_Mera_no_Mi", "Mera Mera no Mi", 13.99 },
                    { 3, "Zoan", "Devil Fruit that allows its user to transform into a leopard hybrid and a full leopard at will, making the user a Leopard Human.", "https://onepieceshop.blob.core.windows.net/onepiece-products/Neko_Neko_no_Mi_Model_Leopard", "Neko Neko no Mi Model Leopard", 10.99 },
                    { 4, "Paramecia", " Devil Fruit whose granted ability is creating a spherical forcefield in which the user can freely alter the orientation, movements, and configuration/anatomy of anything and anyone (themselves included) in a \"surgical\" fashion, making the user a Free Modification Human.<br/>", "https://onepieceshop.blob.core.windows.net/onepiece-products/Ope_Ope_no_Mi", "Ope Ope no Mi", 15.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
