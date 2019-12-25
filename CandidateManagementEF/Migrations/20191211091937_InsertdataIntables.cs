using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidateManagementEF.Migrations
{
    public partial class InsertdataIntables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into skills values ('C#');");
            migrationBuilder.Sql("insert into skills values('Java');");
            migrationBuilder.Sql("insert into skills values('Python');");
            migrationBuilder.Sql("insert into skills values('MVC');");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from skills;");
            migrationBuilder.Sql("DBCC CHECKIDENT('Skills', RESEED, 0);");
        }
    }
}
