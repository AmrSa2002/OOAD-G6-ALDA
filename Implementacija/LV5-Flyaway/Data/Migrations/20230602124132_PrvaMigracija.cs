using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LV5_Flyaway.Data.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Let",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojAviona = table.Column<int>(type: "int", nullable: false),
                    BrojSlobodnihMjesta = table.Column<int>(type: "int", nullable: false),
                    Destinacija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cijena = table.Column<double>(type: "float", nullable: false),
                    Vrijeme_Polijetanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vrijeme_Slijetanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Datum_Polaska = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Let", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "putnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLeta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_putnici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_putnici_Let_IdLeta",
                        column: x => x.IdLeta,
                        principalTable: "Let",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_putnici_IdLeta",
                table: "putnici",
                column: "IdLeta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "putnici");

            migrationBuilder.DropTable(
                name: "Let");
        }
    }
}
