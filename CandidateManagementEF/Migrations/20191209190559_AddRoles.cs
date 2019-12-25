using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidateManagementEF.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into roles values (1, 'admin');");
            migrationBuilder.Sql("insert into roles values (2, 'candidate');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from roles");

        }
    }
}
