using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDB.Migrations
{
    public partial class UpdateTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Teachers",
                newName: "FirstNamez");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstNamez",
                table: "Teachers",
                newName: "FirstName");
        }
    }
}
