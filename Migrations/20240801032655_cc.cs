using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    public partial class cc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "EmployeeDetails",
                newName: "UniversityId");

            migrationBuilder.AddColumn<long>(
                name: "UniversityId",
                table: "TeacherDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UniversityId",
                table: "StudentDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UniversityId",
                table: "DepartmentDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "TeacherDetails");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "StudentDetails");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "DepartmentDetails");

            migrationBuilder.RenameColumn(
                name: "UniversityId",
                table: "EmployeeDetails",
                newName: "DepartmentId");
        }
    }
}
