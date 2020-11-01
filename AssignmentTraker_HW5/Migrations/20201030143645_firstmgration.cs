using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentTraker_HW5.Migrations
{
    public partial class firstmgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    CourseName = table.Column<string>(nullable: false),
                    AssignmentTitle = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");
        }
    }
}
