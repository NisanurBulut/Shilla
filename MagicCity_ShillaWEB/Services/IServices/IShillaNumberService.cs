using MagicShilla_Utility.Dto;

namespace MagicCity_ShillaWEB.Services.IServices
{
    public interface IShillaNumberService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(ShillaNumberCreateDto param);
        Task<T> UpdateAsync<T>(ShillaNumberUpdateDto param);
        Task<T> DeleteAsync<T>(int id);
    }
}
