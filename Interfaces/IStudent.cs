namespace webapi.Interfaces
{
    using Application.DataTransferModels.ResponseModels;
    using webapi.DataTransferModel;


    public interface IStudent
    {
        Task<ResponseVM> CreateStudent(CreateStudentVM model);
        Task<ResponseVM> GetStudent();
        Task<ResponseVM> UpdateStudent(UpdateStudentVM model);
        Task<ResponseVM> DeleteStudent(long StudentId);
        Task<ResponseVM> GetStudents(long StudentId);
    }
}
