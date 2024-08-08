using Application.DataTransferModels.ResponseModels;

namespace webapi.Interfaces
{
    public interface IUser
    {
        Task<ResponseVM>VerifyEmail(string Email);
    }
}