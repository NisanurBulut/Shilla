using MagicCity_ShillaAPI.Models;
using System.Linq.Expressions;

namespace MagicCity_ShillaAPI.Repository.IRepository
{
    public interface IShillaRepository:IRepository<Shilla>
    {
      
        Task<Shilla> UpdateAsync(Shilla shillaEntity);
    }
}
