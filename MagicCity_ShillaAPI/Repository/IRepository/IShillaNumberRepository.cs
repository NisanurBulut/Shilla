using MagicShilla_Utility.Entity;

namespace MagicCity_ShillaAPI.Repository.IRepository
{
    public interface IShillaNumberRepository :IRepository<ShillaNumber>
    {
        Task<ShillaNumber> UpdateAsync(ShillaNumber shillaNumberEntity);
    }
}
