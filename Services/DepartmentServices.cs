using Application.DataTransferModels.ResponseModels;
using Dapper;
using Microsoft.Data.SqlClient;
using webapi.DataTransferModel;
using webapi.Interfaces;
using webapi.Models;

    public class DepartmentServices:IDepartment
    {
    private readonly IConfiguration _Configuration;
    public DepartmentServices(IConfiguration configuration) {
        _Configuration = configuration;
    }
    public async Task<ResponseVM> CreateDepartment(CreateDepartmentVM model)
    {   
        ResponseVM response=ResponseVM.Instance;
        string connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"INSERT INTO DepartmentDetails (DepartmentName,DepartDescription)VALUES (@DepartmentName,@DepartDescription)";
        using var con = new SqlConnection(connectionstring);
        con.Open();
        var parameters = new { DepartmentName = model.DepartmentName, DepartDescription = model.DepartDescription };
        int result = await con.ExecuteAsync(query, parameters);
        if (result == 0)
        {       
            response.responseCode = 400;
            response.errorMessage = "create unsuccessfully";
            return response;
        }
        response.responseCode = 200;
        response.responseMessage = "create Successfully";
        return response;
    }
    public async Task<ResponseVM> DeleteDepartment(long DepartmentId)
    {
        ResponseVM response = ResponseVM.Instance;
        string connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"DELETE FROM DepartmentDetails where DepartmentId=@DepartmentId";
        using var con = new SqlConnection(connectionstring);
        con.Open();
        var parameters = new { DepartmentId = DepartmentId };
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
    public async Task<ResponseVM> GetDepartment()
    {
        ResponseVM response = ResponseVM.Instance;
        string Connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"SELECT * From DepartmentDetails ";
        using var con = new SqlConnection(Connectionstring);
        con.Open();
        IEnumerable<Department> Department = await con.QueryAsync<Department>(query);
        if (Department == null)
        {
            response.responseCode = 400;
            response.errorMessage = "Get unsuccessfully";
            return response;
        }
        response.responseCode = 200;
        response.data = Department;
        return response;
    }

    public async Task<ResponseVM> UpdateDepartment(UpdateDepartmentVM model)
    {

        ResponseVM response = ResponseVM.Instance;
        string connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"UPDATE DepartmentDetails SET DepartmentName=@DepartmentName,DepartDescription=@DepartDescription WHERE DepartmentId=@DepartmentId ";
        using var con = new SqlConnection(connectionstring);
        con.Open();
        var parameters = new { DepartmentName = model.DepartmentName, DepartDescription = model.DepartDescription, DepartmentId = model.DepartmentId };
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
    public async Task<ResponseVM> GetDepartments(long DepartmentId)
    {
        ResponseVM response = ResponseVM.Instance;
        string Connectionstring = _Configuration.GetConnectionString("UniversityContext");
        string query = $"SELECT * From DepartmentDetails ";
        using var con = new SqlConnection(Connectionstring);
        con.Open();
        IEnumerable<Department> Department = await con.QueryAsync<Department>(query);
        if (Department == null)
        {
            response.responseCode = 400;
            response.errorMessage = "Get unsuccessfully";
            return response;
        }
        response.responseCode = 200;
        response.data = Department;
        return response;
    }


}
