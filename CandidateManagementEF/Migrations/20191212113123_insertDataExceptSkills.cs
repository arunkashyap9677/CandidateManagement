using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidateManagementEF.Migrations
{
    public partial class insertDataExceptSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "insert into users values (1, 'admin', 'admin', 'admin@example.com', 'admin@123', 'address of admin', null);" +
                "insert into users values(2, 'arun', 'kashyap', 'arun@example.com', 'arun@123', 'address of arun', null);" +
                "insert into users values(2, 'nishant', 'miglani', 'nishant@example.com', 'nishant@123', 'address of nishant', null);" +
                "insert into users values(2, 'amrit', 'pal', 'amrit@example.com', 'amrit@123', 'address of amrit', null);" +
                "insert into users values(2, 'robin', 'manchanda', 'robin@example.com', 'robin@123', 'address of robin', null);" +
                "insert into users values(2, 'tejas', 'sharma', 'tejas@example.com', 'tejas@123', 'address of tejas', null);" +
                "insert into users values(2, 'namit', 'sharma', 'namit@example.com', 'namit@123', 'address of namit', null);" +
                "insert into SkillUser values(1, 2);" +
                "insert into SkillUser values(2, 2);" +
                "insert into SkillUser values(3, 2);" +
                "insert into SkillUser values(4, 2);" +
                "insert into SkillUser values(1, 3);" +
                "insert into SkillUser values(2, 3);" +
                "insert into SkillUser values(4, 3);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from SkillUser;" +
                "delete from users;" +
                "DBCC CHECKIDENT('users', RESEED, 0);" +
                "DBCC CHECKIDENT('skilluser', RESEED, 0); ");

        }
    }
}
