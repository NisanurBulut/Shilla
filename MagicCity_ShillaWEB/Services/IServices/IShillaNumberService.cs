using MagicShilla_Utility.Dto;

namespace MagicCity_ShillaWEB.Services.IServices
{
    public interface IShillaNumberService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(CreateShillaDto param);
        Task<T> UpdateAsync<T>(UpdateShillaDto param);
        Task<T> DeleteAsync<T>(int id);
    }
}
