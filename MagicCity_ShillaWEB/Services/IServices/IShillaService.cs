using MagicShilla_Utility.Dto;

namespace MagicCity_ShillaWEB.Services.IServices
{
    public interface IShillaService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateAsync<T>(CreateShillaDto param, string token);
        Task<T> UpdateAsync<T>(UpdateShillaDto param, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
