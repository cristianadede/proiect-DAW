using Microsoft.EntityFrameworkCore.Migrations;

namespace proiectDAW.Migrations
{
    public partial class PKNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Notas",
                table: "Notas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notas",
                table: "Notas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_FilmId",
                table: "Notas",
                column: "FilmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Notas",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_FilmId",
                table: "Notas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notas",
                table: "Notas",
                columns: new[] { "FilmId", "UtilizatorId" });
        }
    }
}
