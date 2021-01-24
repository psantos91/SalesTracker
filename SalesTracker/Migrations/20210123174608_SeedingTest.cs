using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesTracker.Migrations
{
    public partial class SeedingTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SellerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Contact = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    WorkingRegion = table.Column<string>(nullable: true),
                    BaseSalary = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FarmAddress = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    Contact = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    NIF = table.Column<int>(nullable: false),
                    MainCrop = table.Column<string>(nullable: true),
                    SecondaryCrop = table.Column<string>(nullable: true),
                    FarmArea = table.Column<double>(nullable: false),
                    HasBought = table.Column<bool>(nullable: false),
                    Rating = table.Column<int>(maxLength: 5, nullable: false),
                    SellerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "BaseSalary", "BirthDate", "Contact", "Email", "FirstName", "LastName", "WorkingRegion" },
                values: new object[] { 1, 800m, new DateTime(1991, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 919551288, "paulo@gmail.com", "Paulo", "Santos", "Center Coast" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "BaseSalary", "BirthDate", "Contact", "Email", "FirstName", "LastName", "WorkingRegion" },
                values: new object[] { 2, 900m, new DateTime(1989, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 914558622, "joao@gmail.com", "Joao", "Martins", "North Coast" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "BaseSalary", "BirthDate", "Contact", "Email", "FirstName", "LastName", "WorkingRegion" },
                values: new object[] { 3, 800m, new DateTime(1984, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 914587533, "ricardo@gmail.com", "Ricardo", "Casal", "North" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "BillingAddress", "CompanyName", "Contact", "Email", "FarmAddress", "FarmArea", "FirstName", "HasBought", "LastName", "MainCrop", "NIF", "Rating", "SecondaryCrop", "SellerId" },
                values: new object[,]
                {
                    { 1, "Tocha", "Company 1", 919885411, "fabio@gmail.com", "Tocha", 2.5, "Fabio", true, "Martins", "Morango", 208458423, 5, "Couve", 1 },
                    { 2, "Ventosa", "Company 2", 914586522, "rui@gmail.com", "Ventosa", 6.0, "Rui", true, "Baptista", "Vinha", 248521446, 5, "Milho", 1 },
                    { 3, "Ventosa", "Company 3", 918452233, "paula@gmail.com", "Ventosa", 16.0, "Paula", true, "Almeida", "Vinha", 248753226, 4, "", 1 },
                    { 4, "Vila do Conde", "Company 4", 914885622, "fernando@gmail.com", "Vila do Conde", 1.0, "Fernando", false, "Almeida", "Alface", 501458969, 2, "Alho Frances", 2 },
                    { 5, "Porto", "Company 5", 914587522, "antonio@gmail.com", "Felgueiras", 7.7999999999999998, "Antonio", true, "Silva", "Mirtilo", 501245889, 3, "Kiwi", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_SellerId",
                table: "Clients",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
