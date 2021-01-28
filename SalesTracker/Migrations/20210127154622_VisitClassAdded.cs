using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesTracker.Migrations
{
    public partial class VisitClassAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitDate = table.Column<DateTime>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    Present = table.Column<bool>(nullable: false),
                    FollowUp = table.Column<DateTime>(nullable: false),
                    Observations = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visits_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "VisitId", "ClientId", "FollowUp", "Observations", "Present", "VisitDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apresentação de Calcário", true, new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apresentação de Produtos", true, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apresentação de Fertilizantes", true, new DateTime(2020, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apresentação de Matéria Orgânica", true, new DateTime(2020, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ClientId",
                table: "Visits",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visits");
        }
    }
}
