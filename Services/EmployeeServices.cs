using System.Data;
using Application.DataTransferModels.ResponseModels;
using Dapper;
using Microsoft.Data.SqlClient;
using webapi.DataTransferModel;
using webapi.Interfaces;
using webapi.Models;


namespace webapi.Services
{
    public class EmployeeServices : IEmployee
    {

        private readonly IConfiguration _Configuration;
        public EmployeeServices(IConfiguration configuration)
        {
            _Configuration = configuration;
        }
        public async Task<ResponseVM> CreateEmployee(CreateEmployeeVM model)
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _Configuration.GetConnectionString("UniversityContext");
            string query = $"INSERT INTO EmployeeDetails (Name,Title) VALUES(@Name,@Title)";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            var parameters = new { Name = model.Name, Title = model.Title };
            int result = await con.ExecuteAsync(query, parameters);
            if (result == 0)
            {
                response.responseCode = 400;
                response.errorMessage = "insert unsuccessfully";
                return response;
            }
            response.responseCode = 200;
            response.responseMessage = "insert successfully";
            return response;

        }
        public async Task<ResponseVM> GetEmployee(long EmpId)
        {
            ResponseVM response=ResponseVM.Instance;
            string connectionstring = _Configuration.GetConnectionString("UniversityContext");
            using var con = new SqlConnection(connectionstring);
            await con.OpenAsync();
            var parameters = new DynamicParameters();
            parameters.Add("EmpId", EmpId);
            IEnumerable<Employee> result = await con.QueryAsync<Employee>("SP_GetEmployee", parameters, commandType: CommandType.StoredProcedure);
            if (!result.Any())
            {
                response.responseCode = 400;
                response.errorMessage = "Get unsuccessfully";
                return response;
            }
            response.responseCode = 200;
            response.responseMessage = "Get successfully";
            response.data = result;
            return response;
            
                
            
        }
    }
}
