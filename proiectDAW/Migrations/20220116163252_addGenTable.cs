using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proiectDAW.Migrations
{
    public partial class addGenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GenId",
                table: "Films",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Gens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true),
                    NumeGen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gens", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_GenId",
                table: "Films",
                column: "GenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Gens_GenId",
                table: "Films",
                column: "GenId",
                principalTable: "Gens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Gens_GenId",
                table: "Films");

            migrationBuilder.DropTable(
                name: "Gens");

            migrationBuilder.DropIndex(
                name: "IX_Films_GenId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "GenId",
                table: "Films");
        }
    }
}
