using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proiectDAW.Migrations
{
    public partial class UtilizatorFilmNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizators",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    UtilizatorId = table.Column<Guid>(nullable: false),
                    FilmId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => new { x.FilmId, x.UtilizatorId });
                    table.ForeignKey(
                        name: "FK_Notas_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notas_Utilizators_UtilizatorId",
                        column: x => x.UtilizatorId,
                        principalTable: "Utilizators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notas_UtilizatorId",
                table: "Notas",
                column: "UtilizatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Utilizators");
        }
    }
}
