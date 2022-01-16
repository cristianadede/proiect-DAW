using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proiectDAW.Migrations
{
    public partial class ModelsRelationsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Models1",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models3",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models4",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models5",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models2",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Model1Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models2_Models1_Model1Id",
                        column: x => x.Model1Id,
                        principalTable: "Models1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelLegaturas",
                columns: table => new
                {
                    Model3Id = table.Column<Guid>(nullable: false),
                    Model4Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelLegaturas", x => new { x.Model3Id, x.Model4Id });
                    table.ForeignKey(
                        name: "FK_ModelLegaturas_Models3_Model3Id",
                        column: x => x.Model3Id,
                        principalTable: "Models3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelLegaturas_Models4_Model4Id",
                        column: x => x.Model4Id,
                        principalTable: "Models4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models6",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCreare = table.Column<DateTime>(nullable: true),
                    DataModificare = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Model5Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models6", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models6_Models5_Model5Id",
                        column: x => x.Model5Id,
                        principalTable: "Models5",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModelLegaturas_Model4Id",
                table: "ModelLegaturas",
                column: "Model4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Models2_Model1Id",
                table: "Models2",
                column: "Model1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Models6_Model5Id",
                table: "Models6",
                column: "Model5Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelLegaturas");

            migrationBuilder.DropTable(
                name: "Models2");

            migrationBuilder.DropTable(
                name: "Models6");

            migrationBuilder.DropTable(
                name: "Models3");

            migrationBuilder.DropTable(
                name: "Models4");

            migrationBuilder.DropTable(
                name: "Models1");

            migrationBuilder.DropTable(
                name: "Models5");
        }
    }
}
