using Microsoft.EntityFrameworkCore.Migrations;

namespace proiectDAW.Migrations
{
    public partial class publicEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Utilizators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "Utilizators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parola",
                table: "Utilizators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "Utilizators",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stele",
                table: "Notas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Films",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Limba",
                table: "Films",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titlu",
                table: "Films",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Utilizators");

            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Utilizators");

            migrationBuilder.DropColumn(
                name: "Parola",
                table: "Utilizators");

            migrationBuilder.DropColumn(
                name: "Prenume",
                table: "Utilizators");

            migrationBuilder.DropColumn(
                name: "Stele",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Limba",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Titlu",
                table: "Films");
        }
    }
}
