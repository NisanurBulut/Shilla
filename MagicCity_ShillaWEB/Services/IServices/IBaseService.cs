using MagicCity_ShillaWEB.Models;
using MagicShilla_Utility.VM;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace MagicCity_ShillaWEB.Services.IServices
{
    public interface IBaseService
    {

        APIResponseModel responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequestModel apiRequest);
    }
}
