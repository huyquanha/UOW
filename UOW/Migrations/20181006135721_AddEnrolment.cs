using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UOW.Migrations
{
    public partial class AddEnrolment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enrolment",
                columns: table => new
                {
                    EnrolmentID = table.Column<int>(nullable: false),
                    StudentID = table.Column<string>(nullable: false),
                    SubjectCode = table.Column<string>(nullable: false),
                    EnrolDate = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolment", x => new { x.StudentID, x.SubjectCode });
                    table.ForeignKey(
                        name: "FK_Enrolment_AspNetUsers_StudentID",
                        column: x => x.StudentID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrolment_Subject_SubjectCode",
                        column: x => x.SubjectCode,
                        principalTable: "Subject",
                        principalColumn: "SubjectCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrolment_SubjectCode",
                table: "Enrolment",
                column: "SubjectCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrolment");
        }
    }
}
