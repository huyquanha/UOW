using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UOW.Migrations
{
    public partial class AddEnrolment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enrolment",
                columns: table => new
                {
                    EnrolmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentID = table.Column<string>(nullable: true),
                    SubjectCode = table.Column<string>(nullable: true),
                    EnrolDate = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolment", x => x.EnrolmentID);
                    table.ForeignKey(
                        name: "FK_Enrolment_AspNetUsers_StudentID",
                        column: x => x.StudentID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrolment_Subject_SubjectCode",
                        column: x => x.SubjectCode,
                        principalTable: "Subject",
                        principalColumn: "SubjectCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrolment_StudentID",
                table: "Enrolment",
                column: "StudentID");

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
