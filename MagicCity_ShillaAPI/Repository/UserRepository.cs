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
        public UserRepository(ShillaDbContext dbContext) : base(dbContext)
        {

            _dbContext = dbContext;
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
            throw new NotImplementedException();
        }

        public Task<LocalUser> RegisterAsync(RegisterationRequestDto registerationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
