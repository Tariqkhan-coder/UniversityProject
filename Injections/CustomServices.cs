using webapi.Interfaces;
using webapi.Services;

namespace webapi.Injections
{
    public static class CustomServices
    {
        public static void AddCustomServices(this IServiceCollection services)
        {

            services.AddScoped<IUser, UserServices>();
        }
    }
}


