using MagicShilla_Utility.Dto;
using MagicShilla_Utility.Entity;
using System.Linq.Expressions;

namespace MagicCity_ShillaAPI.Repository.IRepository
{
    public interface IUserRepository:IRepository<LocalUser>
    {
        Task<bool> IsUniqueUserAsync(string userName);
        Task<LoginResponseDto> LoginUserAsync(LoginRequestDto loginRequestDto);
        Task<LocalUser> RegisterAsync(RegisterationRequestDto registerationRequestDto);
    }
}
