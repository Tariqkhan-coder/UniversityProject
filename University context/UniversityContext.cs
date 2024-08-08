using Microsoft.EntityFrameworkCore;
using webapi.Models;
namespace webapi.University_context
{
    public class UniversityContext:DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {

        }


       

        public DbSet<User> Userdetails { get; set; }






    }
}
