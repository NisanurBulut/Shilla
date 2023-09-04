using MagicCity_ShillaWEB.Models;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace MagicCity_ShillaWEB.Services.IServices
{
    public interface IBaseService
    {

        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
