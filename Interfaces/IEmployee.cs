namespace webapi.Interfaces
{
    using Application.DataTransferModels.ResponseModels;
    using webapi.DataTransferModel;
    public interface IEmployee
    {

        Task<ResponseVM> CreateEmployee(CreateEmployeeVM model);
        Task<ResponseVM> GetEmployee(long EmpId);

    }
}
