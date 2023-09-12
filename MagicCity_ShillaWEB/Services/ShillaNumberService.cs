using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility;
using MagicShilla_Utility.Dto;

namespace MagicCity_ShillaWEB.Services
{
    public class ShillaNumberService : BaseService, IShillaNumberService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private string _shillaUrl;
      
        public ShillaNumberService(IHttpClientFactory httpClientFactoryParam, IConfiguration configuration) : base(httpClientFactoryParam)
        {
            this._httpClientFactory = httpClientFactoryParam;
            this._shillaUrl = configuration.GetValue<string>("ServiceUrls:ShillaAPI");
        }

        public Task<T> CreateAsync<T>(ShillaNumberCreateDto param)
        {
            return SendAsync<T>(new APIRequest() { apiType = SD.ApiType.POST, Data = param, Url = $"{_shillaUrl}/ShillaNumber/CreateShillaNumber" });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.DELETE,
                Url = $"{_shillaUrl}/ShillaNumber/DeleteShillaNumber/{id}"
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.GET,
                Url = $"{_shillaUrl}/ShillaNumber/GetShillaNumbers"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.GET,
                Url = $"{_shillaUrl}/ShillaNumber/GetShillaNumber/{id}"
            });
        }

        public Task<T> UpdateAsync<T>(ShillaNumberUpdateDto param)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.PUT,
                Data = param,
                Url = $"{_shillaUrl}/ShillaNumber/UpdateShillaNumber/{param.ShillaNo}"
            });
        }
    }
}
