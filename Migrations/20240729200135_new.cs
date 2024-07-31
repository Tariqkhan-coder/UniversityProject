using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentDetails",
                columns: table => new
                {
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    DepartDescription = table.Column<string>(type: "NVARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentDetails", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    StudentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    lastName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Age = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CNIC = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    DateofBirth = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Religion = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    AdmissionDate = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Country = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    State = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDetails",
                columns: table => new
                {
                    TeacherId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CNIC = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Religion = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDetails", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "UniversityDetails",
                columns: table => new
                {
                    UniversityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    location = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    EstablishedYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityDetails", x => x.UniversityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentDetails");

            migrationBuilder.DropTable(
                name: "StudentDetails");

            migrationBuilder.DropTable(
                name: "TeacherDetails");

            migrationBuilder.DropTable(
                name: "UniversityDetails");
        }
    }
}
