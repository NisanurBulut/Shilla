using AutoMapper;
using MagicCity_ShillaAPI.Repository.IRepository;
using MagicCity_ShillaWEB.Models;
using MagicShilla_Utility.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace MagicCity_ShillaAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : Controller
    {
        protected APIResponse _apiResponseModel;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepo;
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            this._apiResponseModel = new APIResponse();
            this._userRepo = userRepository;
            this._mapper = mapper;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto param)
        {
            if (!ModelState.IsValid)
            {
                _apiResponseModel.setBadRequestWithErrorMessage("ModelState is not valid");
                return BadRequest(_apiResponseModel);
            }

            var loginResponseItem = await _userRepo.LoginUserAsync(param);
            if (loginResponseItem == null || string.IsNullOrEmpty(loginResponseItem.Token))
            {
                _apiResponseModel.setBadRequestWithErrorMessage("Username or password is incorrect");
                return BadRequest(loginResponseItem);
            }

            _apiResponseModel.setOk(loginResponseItem);
            return Ok(_apiResponseModel);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterationRequestDto param)
        {
            if (!ModelState.IsValid)
            {
                _apiResponseModel.setBadRequestWithErrorMessage("ModelState is not valid");
                return BadRequest(_apiResponseModel);
            }
            var isUniqueItem = await _userRepo.IsUniqueUserAsync(param.UserName);
            if (!isUniqueItem)
            {
                _apiResponseModel.setBadRequestWithErrorMessage("User is already exist.");
                return BadRequest(_apiResponseModel);
            }

            var userEntityItem = await _userRepo.RegisterAsync(param);
            if (userEntityItem == null)
            {
                this._apiResponseModel.setBadRequestWithErrorMessage("Registering process is failured");
                return BadRequest(_apiResponseModel);
            }
            _apiResponseModel.setOk(userEntityItem);
            return Ok(_apiResponseModel);
        }
    }
}
