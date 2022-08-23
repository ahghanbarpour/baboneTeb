using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "introduction",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pic = table.Column<string>(nullable: true),
                    videoIntro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_introduction", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "packages",
                columns: table => new
                {
                    packageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    descript = table.Column<string>(nullable: true),
                    pointLine = table.Column<byte>(nullable: false),
                    pic = table.Column<string>(nullable: true),
                    warmPdf = table.Column<string>(nullable: true),
                    coldPdf = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packages", x => x.packageId);
                });

            migrationBuilder.CreateTable(
                name: "tests",
                columns: table => new
                {
                    testId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phoneNumber = table.Column<string>(nullable: true),
                    age = table.Column<byte>(nullable: false),
                    packageId = table.Column<int>(nullable: false),
                    answerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tests", x => x.testId);
                    table.ForeignKey(
                        name: "FK_tests_packages_packageId",
                        column: x => x.packageId,
                        principalTable: "packages",
                        principalColumn: "packageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    questionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    answerId = table.Column<int>(nullable: false),
                    packageId = table.Column<int>(nullable: false),
                    testId = table.Column<int>(nullable: true),
                    q = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.questionId);
                    table.ForeignKey(
                        name: "FK_questions_packages_packageId",
                        column: x => x.packageId,
                        principalTable: "packages",
                        principalColumn: "packageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_questions_tests_testId",
                        column: x => x.testId,
                        principalTable: "tests",
                        principalColumn: "testId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "answers",
                columns: table => new
                {
                    answerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    questionId = table.Column<int>(nullable: false),
                    point = table.Column<byte>(nullable: false),
                    a = table.Column<string>(nullable: true),
                    testId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answers", x => x.answerId);
                    table.ForeignKey(
                        name: "FK_answers_questions_questionId",
                        column: x => x.questionId,
                        principalTable: "questions",
                        principalColumn: "questionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_answers_tests_testId",
                        column: x => x.testId,
                        principalTable: "tests",
                        principalColumn: "testId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_answers_questionId",
                table: "answers",
                column: "questionId");

            migrationBuilder.CreateIndex(
                name: "IX_answers_testId",
                table: "answers",
                column: "testId");

            migrationBuilder.CreateIndex(
                name: "IX_questions_packageId",
                table: "questions",
                column: "packageId");

            migrationBuilder.CreateIndex(
                name: "IX_questions_testId",
                table: "questions",
                column: "testId");

            migrationBuilder.CreateIndex(
                name: "IX_tests_packageId",
                table: "tests",
                column: "packageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "answers");

            migrationBuilder.DropTable(
                name: "introduction");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "tests");

            migrationBuilder.DropTable(
                name: "packages");
        }
    }
}
