using webapi.Interfaces;
using webapi.Services;

namespace webapi.InjectServices
{
    public static class CustomServices
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUniversity, UniversityServices>();
            services.AddScoped<ITeacher, TeacherServices>();
            services.AddScoped<IStudent, StudentServices>();
            services.AddScoped<IDepartment, DepartmentServices>();
            services.AddScoped<IEmployee, EmployeeServices>();
           
            
           
        }
    }
}
