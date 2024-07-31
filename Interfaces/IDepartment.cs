namespace webapi.Interfaces
{
    using Application.DataTransferModels.ResponseModels;
    using webapi.DataTransferModel;
    public interface IDepartment
    {
        Task<ResponseVM> CreateDepartment(CreateDepartmentVM model);
        Task<ResponseVM> UpdateDepartment(UpdateDepartmentVM model);
        Task<ResponseVM> DeleteDepartment( long DepartmentId);
        Task<ResponseVM> GetDepartment();
        Task<ResponseVM> GetDepartments(long DepartmentId);
    }
}
