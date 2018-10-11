using Microsoft.EntityFrameworkCore.Migrations;

namespace UOW.Migrations
{
    public partial class AddSubjectSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Session",
                table: "Subject",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Session",
                table: "Subject");
        }
    }
}
