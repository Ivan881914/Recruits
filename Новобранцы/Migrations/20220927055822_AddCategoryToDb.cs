using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recruits.Migrations
{
    public partial class AddCategoryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecruitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruitLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruitJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstInterview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestRealizationTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestСompletionTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
