using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesTracker.Migrations
{
    public partial class SalaryAsFloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "BaseSalary",
                table: "Sellers",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 1,
                column: "BaseSalary",
                value: 800f);

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 2,
                column: "BaseSalary",
                value: 900f);

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 3,
                column: "BaseSalary",
                value: 800f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "BaseSalary",
                table: "Sellers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 1,
                column: "BaseSalary",
                value: 800m);

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 2,
                column: "BaseSalary",
                value: 900m);

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 3,
                column: "BaseSalary",
                value: 800m);
        }
    }
}
