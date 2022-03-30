using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makula_semestralni_prace.Migrations
{
    public partial class CompetitionUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompetitionId",
                table: "Rounds",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompetitionId",
                table: "Competitors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rounds_CompetitionId",
                table: "Rounds",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_CompetitionId",
                table: "Competitors",
                column: "CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitors_Competition_CompetitionId",
                table: "Competitors",
                column: "CompetitionId",
                principalTable: "Competition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rounds_Competition_CompetitionId",
                table: "Rounds",
                column: "CompetitionId",
                principalTable: "Competition",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitors_Competition_CompetitionId",
                table: "Competitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Rounds_Competition_CompetitionId",
                table: "Rounds");

            migrationBuilder.DropIndex(
                name: "IX_Rounds_CompetitionId",
                table: "Rounds");

            migrationBuilder.DropIndex(
                name: "IX_Competitors_CompetitionId",
                table: "Competitors");

            migrationBuilder.DropColumn(
                name: "CompetitionId",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "CompetitionId",
                table: "Competitors");
        }
    }
}
