using MagicCity_ShillaAPI.Models;
using System.Linq.Expressions;

namespace MagicCity_ShillaAPI.Repository.IRepository
{
    public interface IShillaRepository
    {
        Task<List<Shilla>> GetAll(Expression<Func<Shilla>> filter = null);
        Task<Shilla> Get(Expression<Func<Shilla>> filter = null, bool tracked = true);

        Task Create(Shilla shillaEntity);
        Task Remove(Shilla shillaEntity);
        Task Save();
    }
}
