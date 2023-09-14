using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility;
using MagicShilla_Utility.VM;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;

namespace MagicCity_ShillaWEB.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }
        public IHttpClientFactory httpClientFactory { get; set; }
        public BaseService(IHttpClientFactory httpClientFactoryParam)
        {
            responseModel = new();
            httpClientFactory = httpClientFactoryParam;
        }

        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var clientItem = httpClientFactory.CreateClient("ShillaAPI");
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Headers.Add("Accept", "application/json");
                httpRequestMessage.RequestUri = new Uri(apiRequest.Url);

                // Data wont be null when http request is POST or PUT
                if (apiRequest.Data != null)
                {
                    httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8, "application/json");
                }

                switch (apiRequest.apiType)
                {
                    case SD.ApiType.POST:
                        httpRequestMessage.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        httpRequestMessage.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        httpRequestMessage.Method = HttpMethod.Delete;
                        break;
                    default:
                        httpRequestMessage.Method = HttpMethod.Get;
                        break;
                }


                HttpResponseMessage apiResponse = null;
                apiResponse = await clientItem.SendAsync(httpRequestMessage);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var APIResponseItem = JsonConvert.DeserializeObject<T>(apiContent);
                
                return APIResponseItem;

            }
            catch (Exception ex)
            {
                var dtoItem = new APIResponse
                {
                    ErrorMessages = new List<string> { Convert.ToString(ex.Message) },
                    IsSuccess = false
                };
                var responseItem = JsonConvert.SerializeObject(dtoItem);
                var apiResponseItem = JsonConvert.DeserializeObject<T>(responseItem);
                return apiResponseItem;
            }
        }
    }
}
