using Microsoft.EntityFrameworkCore.Migrations;

namespace UOW.Migrations
{
    public partial class UpdateEnrolmentSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Subject",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "Enrolment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Point",
                table: "Enrolment");
        }
    }
}
