using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartQuiz.Migrations
{
    public partial class makeQuiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MakeQuizzes",
                columns: table => new
                {
                    MakeQuizID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Approve = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QuizCategoryId = table.Column<int>(type: "int", nullable: false),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    SupporterID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeQuizzes", x => x.MakeQuizID);
                    table.ForeignKey(
                        name: "FK_MakeQuizzes_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakeQuizzes_QuizCategories_QuizCategoryId",
                        column: x => x.QuizCategoryId,
                        principalTable: "QuizCategories",
                        principalColumn: "QuizCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakeQuizzes_Supporters_SupporterID",
                        column: x => x.SupporterID,
                        principalTable: "Supporters",
                        principalColumn: "SupporterID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MakeQuizzes_PlayerID",
                table: "MakeQuizzes",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_MakeQuizzes_QuizCategoryId",
                table: "MakeQuizzes",
                column: "QuizCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeQuizzes_SupporterID",
                table: "MakeQuizzes",
                column: "SupporterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MakeQuizzes");
        }
    }
}
