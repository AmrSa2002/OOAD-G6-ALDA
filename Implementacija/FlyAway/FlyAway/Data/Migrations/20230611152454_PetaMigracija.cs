using Microsoft.EntityFrameworkCore.Migrations;

namespace FlyAway.Data.Migrations
{
    public partial class PetaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Putnik_IdPutnika",
                table: "Rezervacija");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_IdPutnika",
                table: "Rezervacija");

            migrationBuilder.AddColumn<int>(
                name: "PutnikId",
                table: "Rezervacija",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_PutnikId",
                table: "Rezervacija",
                column: "PutnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Putnik_PutnikId",
                table: "Rezervacija",
                column: "PutnikId",
                principalTable: "Putnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Putnik_PutnikId",
                table: "Rezervacija");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_PutnikId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "PutnikId",
                table: "Rezervacija");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_IdPutnika",
                table: "Rezervacija",
                column: "IdPutnika");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Putnik_IdPutnika",
                table: "Rezervacija",
                column: "IdPutnika",
                principalTable: "Putnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
