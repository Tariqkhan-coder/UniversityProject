using Application.DataTransferModels.ResponseModels;
using Microsoft.Data.SqlClient;
using Dapper;
using webapi.DataTransferModel;
using webapi.Interfaces;
using webapi.Models;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Services
{
    public class TeacherServices : ITeacher
    {
        private readonly IConfiguration _configuration;
        public TeacherServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<ResponseVM> CreateTeacher(CreateTeacherVM model)
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            string query = $"INSERT INTO TeacherDetails (TeacherName, CNIC,Religion, Email,PhoneNumber) VALUES (@TeacherName, @CNIC, @Religion, @Email,@PhoneNumber)";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            var parameters = new { TeacherName = model.TeacherName, CNIC = model.CNIC, Religion = model.Religion, Email = model.Email, PhoneNumber = model.PhoneNumber };
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

        public async Task<ResponseVM> DeleteTeacher(long TeacherId)
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            string query = $"DELETE FROM TeacherDetails where TeacherId =@TeacherId";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            var parameters = new { TeacherId = TeacherId };
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

        public async Task<ResponseVM> GetTeacher()
        {
            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            string query = $"SELECT *FROM TeacherDetails ";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            IEnumerable<Teacher> Teacher = await con.QueryAsync<Teacher>(query);
            if (Teacher == null)
            {
                response.responseCode = 400;
                response.errorMessage = "Get data unsuccessfully";
                return response;
            }
            response.responseCode = 200;
            response.data = Teacher;
            return response;
        }

        public async Task<ResponseVM> UpdateTeacher(UpdateTeacherVM model)
        {

            ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            string query = $"UPDATE TeacherDetails SET TeacherName=@TeacherName, CNIC=@CNIC, Religion=@Religion,Email=@Email,PhoneNumber=@PhoneNumber WHERE TeacherId=@TeacherId ";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            var parameters = new { TeacherName = model.TeacherName, CNIC = model.CNIC, Religion = model.Religion, Email = model.Email, PhoneNumber = model.PhoneNumber, TeacherId = model.TeacherId };
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

        public async Task<ResponseVM> GetTeachers(long TeacherId) { 

        ResponseVM response = ResponseVM.Instance;
            string connectionstring = _configuration.GetConnectionString("UniversityContext");
            using var con=new SqlConnection(connectionstring);
            await con.OpenAsync();
            var parameters = new DynamicParameters();
            parameters.Add("@TeacherId", TeacherId);
            IEnumerable<Teacher> result=await con.QueryAsync<Teacher>("SP_GetTeachers", parameters, commandType: CommandType.StoredProcedure);
            if(!result.Any())
            {
                response.responseCode = 400;
                response.errorMessage = "GetTeachers unsuccessfully";
                return response;
            }
            response.responseCode = 200;
            response.responseMessage = "GetTeachers successfully";
            response.data = result;
            return response;
    }
      

    }
  
   
}
