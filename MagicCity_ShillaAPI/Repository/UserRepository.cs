using MagicCity_ShillaAPI.Repository.IRepository;
using MagicShilla_Utility.Data;
using MagicShilla_Utility.Dto;
using MagicShilla_Utility.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

        public async Task<LoginResponseDto> LoginUserAsync(LoginRequestDto loginRequestDto)
        {
            var userEntity = await _dbContext.LocalUsers.FirstOrDefaultAsync(a => a.UserName.ToLower() == loginRequestDto.UserName.ToLower()
            && a.Password == loginRequestDto.Password);
            if (userEntity == null)
            {
                return new LoginResponseDto
                {
                    Token = "",
                    User = null
                };
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var secretItem = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userEntity.Id.ToString()),
                    new Claim(ClaimTypes.Role,userEntity.Role)

                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new(new SymmetricSecurityKey(secretItem), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenItem = tokenHandler.CreateToken(tokenDescriptor);
            var loginResponseDtoItem = new LoginResponseDto
            {
                Token = tokenHandler.WriteToken(tokenItem),
                User = userEntity
            };
            return loginResponseDtoItem;
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

            return localUserEntity;
        }
    }
}
