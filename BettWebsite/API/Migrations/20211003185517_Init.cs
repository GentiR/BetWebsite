using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bundesliga",
                columns: table => new
                {
                    match_id = table.Column<int>(type: "int", nullable: false),
                    teamsName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    datat = table.Column<DateTime>(type: "datetime", nullable: false),
                    score_home = table.Column<int>(type: "int", nullable: false),
                    score_away = table.Column<int>(type: "int", nullable: false),
                    moneys = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bundesli__9D7FCBA3180CE55F", x => x.match_id);
                });

            migrationBuilder.CreateTable(
                name: "Laliga",
                columns: table => new
                {
                    match_id = table.Column<int>(type: "int", nullable: false),
                    teamsName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    datat = table.Column<DateTime>(type: "datetime", nullable: false),
                    score_home = table.Column<int>(type: "int", nullable: false),
                    score_away = table.Column<int>(type: "int", nullable: false),
                    moneys = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Laliga__9D7FCBA3F57EA5B1", x => x.match_id);
                });

            migrationBuilder.CreateTable(
                name: "Liga1",
                columns: table => new
                {
                    match_id = table.Column<int>(type: "int", nullable: false),
                    teamsName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    datat = table.Column<DateTime>(type: "datetime", nullable: false),
                    score_home = table.Column<int>(type: "int", nullable: false),
                    score_away = table.Column<int>(type: "int", nullable: false),
                    moneys = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Liga1__9D7FCBA30D9C9658", x => x.match_id);
                });

            migrationBuilder.CreateTable(
                name: "PremierLeague",
                columns: table => new
                {
                    match_id = table.Column<int>(type: "int", nullable: false),
                    teamsName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    datat = table.Column<DateTime>(type: "datetime", nullable: false),
                    score_home = table.Column<int>(type: "int", nullable: false),
                    score_away = table.Column<int>(type: "int", nullable: false),
                    moneys = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PremierL__9D7FCBA37B50C052", x => x.match_id);
                });

            migrationBuilder.CreateTable(
                name: "SeriaA",
                columns: table => new
                {
                    match_id = table.Column<int>(type: "int", nullable: false),
                    teamsName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    datat = table.Column<DateTime>(type: "datetime", nullable: false),
                    score_home = table.Column<int>(type: "int", nullable: false),
                    score_away = table.Column<int>(type: "int", nullable: false),
                    moneys = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SeriaA__9D7FCBA34EBBC1C4", x => x.match_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bundesliga");

            migrationBuilder.DropTable(
                name: "Laliga");

            migrationBuilder.DropTable(
                name: "Liga1");

            migrationBuilder.DropTable(
                name: "PremierLeague");

            migrationBuilder.DropTable(
                name: "SeriaA");
        }
    }
}
