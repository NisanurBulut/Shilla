using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility;
using MagicShilla_Utility.Dto;

namespace MagicCity_ShillaWEB.Services
{
    public class ShillaService : BaseService, IShillaService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private string _shillaUrl;
      
        public ShillaService(IHttpClientFactory httpClientFactoryParam, IConfiguration configuration) : base(httpClientFactoryParam)
        {
            this._httpClientFactory = httpClientFactoryParam;
            this._shillaUrl = configuration.GetValue<string>("ServiceUrls:ShillaAPI");
        }

        public Task<T> CreateAsync<T>(CreateShillaDto param)
        {
            return SendAsync<T>(new APIRequest() { apiType = SD.ApiType.POST, Data = param, Url = $"{_shillaUrl}/ShillaAPI/CreateShilla" });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.DELETE,
                Url = $"{_shillaUrl}/ShillaAPI/DeleteShilla/{id}"
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.GET,
                Url = $"{_shillaUrl}/ShillaAPI/GetShillas"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.GET,
                Url = $"{_shillaUrl}/ShillaAPI/GetShilla/{id}"
            });
        }

        public Task<T> UpdateAsync<T>(UpdateShillaDto param)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.PUT,
                Data = param,
                Url = $"{_shillaUrl}/ShillaAPI/UpdateShilla/{param.Id}"
            });
        }
    }
}
