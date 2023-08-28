using MagicShilla_Utility.Data;
using MagicShilla_Utility.Entity;
using MagicShilla_Utility.Dto;
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
