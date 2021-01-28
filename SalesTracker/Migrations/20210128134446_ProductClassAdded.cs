using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesTracker.Migrations
{
    public partial class ProductClassAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    IVA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "IVA", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Fertilizantes Sólidos", 6, "Calcario 25kg", 6.5 },
                    { 2, "Fertilizantes Sólidos", 6, "Calcario 500kg", 110.3 },
                    { 3, "Fertilizantes Sólidos", 6, "Materia Organica 25kg", 7.1200000000000001 },
                    { 4, "Fertilizantes Sólidos", 6, "Materia Organica 500kg", 120.45 },
                    { 5, "Fertilizantes Sólidos", 6, "Adubo Fundo 25kg", 12.5 },
                    { 6, "Fertilizantes Sólidos", 6, "Adubo Fundo 500kg", 145.99000000000001 },
                    { 7, "Fertilizantes Líquidos", 6, "Azoto Foliar 1L", 4.5 },
                    { 8, "Fertilizantes Líquidos", 6, "Azoto Foliar 5L", 18.989999999999998 },
                    { 9, "Fertilizantes Líquidos", 6, "Algas 1Kg", 16.5 },
                    { 10, "Fertilizantes Líquidos", 6, "Algas 5kg", 40.590000000000003 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
