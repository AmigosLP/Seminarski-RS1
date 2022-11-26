using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartQuiz.Migrations
{
    public partial class updateGameLevelGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameLevelGame_GameLevels_GameLevelId",
                table: "GameLevelGame");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLevelGame_Games_GameId",
                table: "GameLevelGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameLevelGame",
                table: "GameLevelGame");

            migrationBuilder.RenameTable(
                name: "GameLevelGame",
                newName: "GameLevelGames");

            migrationBuilder.RenameIndex(
                name: "IX_GameLevelGame_GameLevelId",
                table: "GameLevelGames",
                newName: "IX_GameLevelGames_GameLevelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameLevelGames",
                table: "GameLevelGames",
                columns: new[] { "GameId", "GameLevelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_GameLevelGames_GameLevels_GameLevelId",
                table: "GameLevelGames",
                column: "GameLevelId",
                principalTable: "GameLevels",
                principalColumn: "GameLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLevelGames_Games_GameId",
                table: "GameLevelGames",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameLevelGames_GameLevels_GameLevelId",
                table: "GameLevelGames");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLevelGames_Games_GameId",
                table: "GameLevelGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameLevelGames",
                table: "GameLevelGames");

            migrationBuilder.RenameTable(
                name: "GameLevelGames",
                newName: "GameLevelGame");

            migrationBuilder.RenameIndex(
                name: "IX_GameLevelGames_GameLevelId",
                table: "GameLevelGame",
                newName: "IX_GameLevelGame_GameLevelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameLevelGame",
                table: "GameLevelGame",
                columns: new[] { "GameId", "GameLevelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_GameLevelGame_GameLevels_GameLevelId",
                table: "GameLevelGame",
                column: "GameLevelId",
                principalTable: "GameLevels",
                principalColumn: "GameLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLevelGame_Games_GameId",
                table: "GameLevelGame",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
