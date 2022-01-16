using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proiectDAW.Migrations
{
    public partial class addDetaliuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DetaliuId",
                table: "Films",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Detalius",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true),
                    Descriere = table.Column<string>(nullable: true),
                    Durata = table.Column<int>(nullable: false),
                    FilmId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalius", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_DetaliuId",
                table: "Films",
                column: "DetaliuId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Detalius_DetaliuId",
                table: "Films",
                column: "DetaliuId",
                principalTable: "Detalius",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Detalius_DetaliuId",
                table: "Films");

            migrationBuilder.DropTable(
                name: "Detalius");

            migrationBuilder.DropIndex(
                name: "IX_Films_DetaliuId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "DetaliuId",
                table: "Films");
        }
    }
}
