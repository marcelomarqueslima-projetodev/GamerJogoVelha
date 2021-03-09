using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace GamerJogoVelhaInfraData.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GameName = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    SiglaGame = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NamePlayer = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    SiglaPlayer = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameResults",
                columns: table => new
                {
                    GameId = table.Column<long>(nullable: false),
                    PlayerId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false),
                    Win = table.Column<long>(nullable: true),
                    LastGame = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameResults", x => new { x.PlayerId, x.GameId });
                    table.ForeignKey(
                        name: "FK_GameResults_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameResults_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameResults_GameId",
                table: "GameResults",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameResults");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
