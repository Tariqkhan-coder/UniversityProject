using Application.DataTransferModels.ResponseModels;
using webapi.DataTransferModel;

namespace webapi.Interfaces
{
    public interface IUniversity
    {
        Task<ResponseVM> CreateUniversity(CreateUniversityVM model);
        Task<ResponseVM> UpdateUniversity(UpdateUniversityVM model);
        Task<ResponseVM> DeleteUniversity(long Universityid);
        Task<ResponseVM> GetUniversity();
        Task<ResponseVM> GetUniversities(long UniversityId);
    }
}
