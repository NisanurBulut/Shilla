using MagicShilla_Utility.Data;
using MagicShilla_Utility.Entity;
using MagicCity_ShillaAPI.Repository.IRepository;

namespace MagicCity_ShillaAPI.Repository
{
    public class ShillaNumberRepository : Repository<ShillaNumber>, IShillaNumberRepository
    {
        private ShillaDbContext _context;
        public ShillaNumberRepository(ShillaDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<ShillaNumber> UpdateAsync(ShillaNumber shillaNumberEntity)
        {
            shillaNumberEntity.UpdatedAt = DateTime.Now;
            _context.ShillaNumbers.Update(shillaNumberEntity);
            await _context.SaveChangesAsync();
            return shillaNumberEntity;
        }
    }
}
