using MagicCity_ShillaAPI.Models;

namespace MagicCity_ShillaAPI.Repository.IRepository
{
    public interface IShillaNumberRepository :IRepository<ShillaNumber>
    {
        Task<ShillaNumber> UpdateAsync(ShillaNumber shillaNumberEntity);
    }
}
