using System.ComponentModel.DataAnnotations;
using Application.DataTransferModels.ResponseModels;
using Dapper;
using Microsoft.Data.SqlClient;
using webapi.Interfaces;

namespace webapi.Services
{
    internal class UserServices:IUser
    {
        private readonly IConfiguration _Configuration;
        public UserServices(IConfiguration configuration)
        {
            _Configuration = configuration;
        }
        public async Task<ResponseVM> VerifyEmail(string Email)
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _Configuration.GetConnectionString("UniversityContext");
            string query = $"Select Email From UserDetails Where Email==@Email";
            using var con= new SqlConnection(connectionstring);
            con.Open();
            var parameters = new { Email=Email };
            int result = await con.ExecuteAsync(query, parameters);
            if (result == 0)
            {
                response.responseCode = 400;
                response.errorMessage = "Verify unsuccessfully";
                return response;
            }
            response.responseCode = 200;
            response.responseMessage = "Verify successfully";
            return response;

        }

    }
    
}