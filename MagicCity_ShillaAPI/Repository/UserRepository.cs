using MagicCity_ShillaAPI.Repository.IRepository;
using MagicShilla_Utility.Data;
using MagicShilla_Utility.Dto;
using MagicShilla_Utility.Entity;
using Microsoft.EntityFrameworkCore;

namespace MagicCity_ShillaAPI.Repository
{
    public class UserRepository : Repository<LocalUser>, IUserRepository
    {
        private ShillaDbContext _dbContext;
        private string _secretKey;
        public UserRepository(ShillaDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _secretKey = configuration.GetValue<string>("ApiSettings:Secret");
        }

        public async Task<bool> IsUniqueUserAsync(string userName)
        {
            var userEntity = await _dbContext.LocalUsers.FirstOrDefaultAsync(a => a.UserName == userName);
            if (userEntity == null)
            {
                return true;
            }
            return false;
        }

        public Task<LoginResponseDto> LoginUserAsync(LoginRequestDto loginRequestDto)
        {
            var userEntity = _dbContext.LocalUsers.FirstOrDefault(a => a.UserName.ToLower() == loginRequestDto.UserName.ToLower()
            && a.Password == loginRequestDto.Password);
            if (userEntity == null)
            {
                return null;
            }

        }

        public async Task<LocalUser> RegisterAsync(RegisterationRequestDto registerationRequestDto)
        {
            LocalUser localUserEntity = new()
            {
                UserName = registerationRequestDto.UserName,
                Password = registerationRequestDto.Password,
                FullName = registerationRequestDto.FullName,
                Role = registerationRequestDto.Role
            };
            _dbContext.LocalUsers.Add(localUserEntity);
            await _dbContext.SaveChangesAsync();

            localUserEntity = null;
            return localUserEntity;
        }
    }
}
