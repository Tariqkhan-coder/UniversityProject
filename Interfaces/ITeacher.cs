using Application.DataTransferModels.ResponseModels;
using webapi.DataTransferModel;

namespace webapi.Interfaces
{
    public interface ITeacher
    {
        Task<ResponseVM> CreateTeacher(CreateTeacherVM model);
        Task<ResponseVM> UpdateTeacher(UpdateTeacherVM model);
        Task<ResponseVM> DeleteTeacher(long TeacherId);
        Task<ResponseVM> GetTeacher();
        Task<ResponseVM> GetTeachers(long TeacherId);
    }
}