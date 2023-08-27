using MagicCity_ShillaAPI.Data;
using MagicCity_ShillaAPI.Models;
using MagicCity_ShillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicCity_ShillaAPI.Repository
{
    public class ShillaRepository : IShillaRepository
    {
        private ShillaDbContext _dbContext;
        public ShillaRepository(ShillaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateAsync(Shilla shillaEntity)
        {
          await _dbContext.Shillas.AddAsync(shillaEntity);
            await SaveAsync();
        }

        public async Task<Shilla> GetAsync(Expression<Func<Shilla, bool>> filter = null, bool tracked = true)
        {
            IQueryable<Shilla> queryable = _dbContext.Shillas.AsQueryable();
            if (!tracked)
            {
                queryable = queryable.AsNoTracking();
            }
            if(filter != null)
            {
                queryable=queryable.Where(filter);
            }
            return await queryable.FirstOrDefaultAsync();
        }

        public async Task<List<Shilla>> GetAllAsync(Expression<Func<Shilla, bool>> filter = null)
        {
            IQueryable<Shilla> queryable = _dbContext.Shillas;
            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }
            return await queryable.ToListAsync();
        }

        public async Task RemoveAsync(Shilla shillaEntity)
        {
            _dbContext.Shillas.Remove(shillaEntity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
         await   _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Shilla shillaEntity)
        {
            _dbContext.Shillas.Update(shillaEntity);
            await SaveAsync();
        }
    }
}
