using MagicCity_ShillaAPI.Models;
using System.Linq.Expressions;

namespace MagicCity_ShillaAPI.Repository.IRepository
{
    public interface IShillaRepository
    {
        Task<List<Shilla>> GetAllAsync(Expression<Func<Shilla, bool>> filter = null);
        Task<Shilla> GetAsync(Expression<Func<Shilla, bool>> filter = null, bool tracked = true);

        Task CreateAsync(Shilla shillaEntity);
        Task RemoveAsync(Shilla shillaEntity);
        Task UpdateAsync(Shilla shillaEntity);
        Task SaveAsync();
    }
}
