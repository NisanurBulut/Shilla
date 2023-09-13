using MagicShilla_Utility.Dto;
using MagicShilla_Utility.Entity;

namespace MagicCity_ShillaWEB.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDto loginRequestDto);
        Task<T> RegisterAsync<T>(RegisterationRequestDto registerationRequestDto);
    }
}
