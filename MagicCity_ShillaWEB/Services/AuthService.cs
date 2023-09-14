using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility;
using MagicShilla_Utility.Dto;
using MagicShilla_Utility.Entity;
using MagicShilla_Utility.VM;

namespace MagicCity_ShillaWEB.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private string _shillaUrl;

        public AuthService(IHttpClientFactory httpClientFactoryParam, IConfiguration configuration) : base(httpClientFactoryParam)
        {
            this._httpClientFactory = httpClientFactoryParam;
            this._shillaUrl = configuration.GetValue<string>("ServiceUrls:ShillaAPI");
        }
        public APIResponse responseModel { get ; set ; }

        public Task<T> LoginAsync<T>(LoginRequestDto loginRequestDto)
        {
            return SendAsync<T>(new APIRequest() { 
                apiType = SD.ApiType.POST, 
                Data = loginRequestDto, 
                Url = $"{_shillaUrl}/Users/Login" });
        }

        public Task<T> RegisterAsync<T>(RegisterationRequestDto registerationRequestDto)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.POST,
                Data = registerationRequestDto,
                Url = $"{_shillaUrl}/Users/Login"
            });
        }

    }
}
