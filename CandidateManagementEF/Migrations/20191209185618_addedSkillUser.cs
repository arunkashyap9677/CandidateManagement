using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidateManagementEF.Migrations
{
    public partial class addedSkillUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "SkillUser",
                columns: table => new
                {
                    SkillId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillUser_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser_SkillId",
                table: "SkillUser",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser_UserId",
                table: "SkillUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillUser");

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Users",
                nullable: true);
        }
    }
}
