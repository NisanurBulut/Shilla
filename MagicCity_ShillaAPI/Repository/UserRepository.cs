using AutoMapper;
using MagicCity_ShillaAPI.Repository.IRepository;
using MagicShilla_Utility.Data;
using MagicShilla_Utility.Dto;
using MagicShilla_Utility.Entity;
using Microsoft.AspNetCore.Identity;
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
        private  IMapper _mapper { get; set; }
        private string _secretKey;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserRepository(ShillaDbContext dbContext, IConfiguration configuration, UserManager<ApplicationUser> userManager, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext;
            _secretKey = configuration.GetValue<string>("ApiSettings:Secret");
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<bool> IsUniqueUserAsync(string userName)
        {
            var userEntity = await _dbContext.applicationUsers.FirstOrDefaultAsync(a => a.UserName == userName);
            if (userEntity == null)
            {
                return true;
            }
            return false;
        }

        public async Task<LoginResponseDto> LoginUserAsync(LoginRequestDto loginRequestDto)
        {
            var userEntity = await _dbContext.applicationUsers.FirstOrDefaultAsync(a => a.UserName.ToLower() == loginRequestDto.UserName.ToLower());
            if (userEntity == null)
            {
                return new LoginResponseDto
                {
                    Token = "",
                    User = null
                };
            }
            var isValidUser = await _userManager.CheckPasswordAsync(userEntity,loginRequestDto.Password);
            if (!isValidUser)
            {
                return new LoginResponseDto
                {
                    Token = "",
                    User = null
                };
            }
            var roles = await _userManager.GetRolesAsync(userEntity);
            var tokenHandler = new JwtSecurityTokenHandler();
            var secretItem = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userEntity.Id.ToString()),
                    new Claim(ClaimTypes.Role, roles.FirstOrDefault())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new(new SymmetricSecurityKey(secretItem), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenItem = tokenHandler.CreateToken(tokenDescriptor);
            var loginResponseDtoItem = new LoginResponseDto
            {
                Token = tokenHandler.WriteToken(tokenItem),
                User = _mapper.Map<LocalUserDto>(userEntity),
                Role = roles.FirstOrDefault()
            };
            return loginResponseDtoItem;
        }

        public async Task<LocalUserDto> RegisterAsync(RegisterationRequestDto registerationRequestDto)
        {
            ApplicationUser localUserEntity = new()
            {
                UserName = registerationRequestDto.UserName,
                Email = registerationRequestDto.UserName,
                NormalizedUserName= registerationRequestDto.UserName.ToUpper(),

            };
            var response = await _userManager.CreateAsync(localUserEntity);
            if (response.Succeeded)
            {
                await _userManager.AddToRoleAsync(localUserEntity,"admin");
            }
            var userReturnItem = await _dbContext.applicationUsers.FirstOrDefaultAsync(a => a.UserName == registerationRequestDto.UserName);
            return _mapper.Map<LocalUserDto>(userReturnItem);
        }
    }
}
