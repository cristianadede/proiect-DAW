using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proiectDAW.Migrations
{
    public partial class addComentariuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.CreateTable(
                name: "Comentarius",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true),
                    UtilizatorId = table.Column<Guid>(nullable: false),
                    FilmId = table.Column<Guid>(nullable: false),
                    Mesaj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarius", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarius_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarius_Utilizators_UtilizatorId",
                        column: x => x.UtilizatorId,
                        principalTable: "Utilizators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarius_FilmId",
                table: "Comentarius",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarius_UtilizatorId",
                table: "Comentarius",
                column: "UtilizatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarius");

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCreare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataModificare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Stele = table.Column<int>(type: "int", nullable: false),
                    UtilizatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
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
                name: "IX_Notas_FilmId",
                table: "Notas",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_UtilizatorId",
                table: "Notas",
                column: "UtilizatorId");
        }
    }
}
