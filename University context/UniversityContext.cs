using Microsoft.EntityFrameworkCore;
using webapi.Models;
namespace webapi.University_context
{
    public class UniversityContext:DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {

        }
        public DbSet<University> UniversityDetails { get; set; }
        public DbSet<Teacher> TeacherDetails { get; set; }
        public DbSet<Student> StudentDetails { get; set; }
        public DbSet<Department> DepartmentDetails { get; set; }
        public DbSet<Employee> EmployeeDetails { get; set; }
       




    }
}
