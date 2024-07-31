using System.Data;
using Application.DataTransferModels.ResponseModels;
using Dapper;
using Microsoft.Data.SqlClient;
using webapi.DataTransferModel;
using webapi.Interfaces;
using webapi.Models;

public class StudentServices : IStudent
{
    private readonly IConfiguration _Configuration;
    public StudentServices(IConfiguration configuration)
    {
        _Configuration = configuration;
    }
    public async Task<ResponseVM> CreateStudent(CreateStudentVM model)
    {
        ResponseVM response = ResponseVM.Instance;
        string connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"INSERT INTO StudentDetails (FirstName,lastName,Age,CNIC,DateofBirth,Religion,AdmissionDate,City,Country,State,Email,PhoneNumber) VALUES (@FirstName,@lastName,@Age,@CNIC,@DateofBirth,@Religion,@AdmissionDate,@City,@Country,@State,@Email,@PhoneNumber)";
        using var con = new SqlConnection(connectionstring);
        con.Open();
        var parameters = new { FirstName = model.FirstName, lastName = model.lastName, Age = model.Age, CNIC = model.CNIC, DateofBirth = model.DateofBirth, Religion = model.Religion, AdmissionDate = model.AdmissionDate, City = model.City, Country = model.Country, State = model.State, Email = model.Email, PhoneNumber = model.PhoneNumber };
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
    public async Task<ResponseVM> DeleteStudent(long StudentID)
    {
        ResponseVM response = ResponseVM.Instance;
        string connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"DELETE FROM StudentDetails where StudentID =@StudentID";
        using var con = new SqlConnection(connectionstring);
        con.Open();
        var parameters = new { StudentID = StudentID };
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
    public async Task<ResponseVM> GetStudent()
    {
        ResponseVM response = ResponseVM.Instance;
        string Connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"SELECT * From StudentDetails ";
        using var con = new SqlConnection(Connectionstring);
        con.Open();
        IEnumerable<Student> Student = await con.QueryAsync<Student>(query);
        if (Student == null)
        {
            response.responseCode = 400;
            response.errorMessage = "Get unsuccessfully";
            return response;
        }
        response.responseCode = 200;
        response.data = Student;
        return response;
    }

    public async Task<ResponseVM> UpdateStudent(UpdateStudentVM model)
    {

        ResponseVM response = ResponseVM.Instance;
        string connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"UPDATE StudentDetails SET FirstName=@FirstName,lastName=@lastName,Age=@Age,CNIC=@CNIC,DateofBirth=@DateofBirth,Religion=@Religion,AdmissionDate=@AdmissionDate,City=@City,Country=@Country,State=@State,Email=@Email,PhoneNumber=@PhoneNumber  WHERE StudentID=@StudentID ";
        using var con = new SqlConnection(connectionstring);
        con.Open();
        var parameters = new { FirstName = model.FirstName, lastName = model.lastName, Age = model.Age, CNIC = model.CNIC, DateofBirth = model.DateofBirth, Religion = model.Religion, AdmissionDate = model.AdmissionDate, City = model.City, Country = model.Country, State = model.State, Email = model.Email, PhoneNumber = model.PhoneNumber ,StudentID=model.StudentID};
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
      public async Task<ResponseVM> GetStudents(long StudentId)
    {
        ResponseVM response = ResponseVM.Instance;
        string Connectionstring = _Configuration.GetConnectionString("UniversityContext");
        using var con = new SqlConnection(Connectionstring);
       await con.OpenAsync();
        var parameters = new DynamicParameters();
        parameters.Add("@StudentId", StudentId);
        IEnumerable<Student> result = await con.QueryAsync<Student>("SP_GetStudents", parameters, commandType: CommandType.StoredProcedure);
        if (!result.Any())
        {
            response.responseCode = 400;
            response.errorMessage = "Get unsuccessfully";
            return response;
        }
        response.responseCode = 200;
        response.data = result;
        return response;
    }



}



