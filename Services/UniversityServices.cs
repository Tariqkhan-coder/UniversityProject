using System.Collections;
using System.Data;
using Application.DataTransferModels.ResponseModels;
using Dapper;
using Microsoft.Data.SqlClient;
using webapi.DataTransferModel;
using webapi.Interfaces;
using webapi.Models;

namespace webapi.Services
{
    public class UniversityServices : IUniversity
    {
        private readonly IConfiguration _configuration;
        public UniversityServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<ResponseVM> CreateUniversity(CreateUniversityVM model)
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            string query = $"INSERT INTO UniversityDetails (UniversityName, location, EstablishedYear) VALUES (@UniversityName, @location, @EstablishedYear)";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            var parameters = new { UniversityName = model.UniversityName, location = model.location, EstablishedYear = model.EstablishedYear };
            int result = await con.ExecuteAsync(query, parameters);
            if (result == 0)
            {
                response.responseCode = 400;
                response.errorMessage = "insert unsuccessfully";
                return response;
            }
            response.responseCode = 200;
            response.responseMessage = "inserted successfully";
            return response;
        }

        public async Task<ResponseVM> DeleteUniversity(long Universityid)
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            string query = $"DELETE FROM UniversityDetails where Universityid =@Universityid";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            var parameters = new { Universityid = Universityid };
            int result = await con.ExecuteAsync(query, parameters);
            if (result == 0)
            {
                response.responseCode = 400;
                response.errorMessage = "deleted unsuccessfully";
                return response;
            }
            response.responseCode = 200;
            response.responseMessage = "delete successfully";
            return response;


        }

        public async Task<ResponseVM> GetUniversity()
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            string query = $"SELECT *FROM UniversityDetails ";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            IEnumerable<University> university = await con.QueryAsync<University>(query);
            if (university == null)
            {
                response.responseCode = 400;
                response.errorMessage = "Get data unsuccessfully";
                return response;
            }
            response.responseCode = 200;
            response.data = university;
            return response;
        }

        public async Task<ResponseVM> UpdateUniversity(UpdateUniversityVM model)
        {

            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            string query = $"UPDATE UniversityDetails SET UniversityName=@UniversityName ,Location=@location,EstablishedYear=@EstablishedYear WHERE @Universityid=@Universityid ";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            var parameters = new { UniversityName = model.UniversityName, Location = model.location, EstablishedYear = model.EstablishedYear, Universityid = model.UniversityId };
            int result = await con.ExecuteAsync(query, parameters);
            if (result == 0)
            {
                response.responseCode = 400;
                response.errorMessage = "Update unsuccessfully";
                return response;

            }
            response.responseCode = 200;
            response.responseMessage = "update successfully";
            return response;
        }
        public async Task<ResponseVM> GetUniversities(long UniversityId)
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            using var con = new SqlConnection(connectionstring);
            await con.OpenAsync();
            var parameters = new DynamicParameters();
            parameters.Add("@UniversityId", UniversityId);
            IEnumerable<University> result = await con.QueryAsync<University>("SP_GetUniversities", parameters, commandType: CommandType.StoredProcedure);
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