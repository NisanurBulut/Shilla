using MagicCity_ShillaAPI.Data;
using MagicCity_ShillaAPI.Models;
using MagicCity_ShillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicCity_ShillaAPI.Repository
{
    public class ShillaRepository : Repository<Shilla>, IShillaRepository
    {
        private ShillaDbContext _dbContext;
        public ShillaRepository(ShillaDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
       

    
        public async Task<Shilla> UpdateAsync(Shilla shillaEntity)
        {
            shillaEntity.UpdatedAt=DateTime.Now;
            _dbContext.Shillas.Update(shillaEntity);
            await _dbContext.SaveChangesAsync();
            return shillaEntity;
        }
    }
}
