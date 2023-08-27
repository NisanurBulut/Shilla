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
        public async Task Create(Shilla shillaEntity)
        {
          await _dbContext.Shillas.AddAsync(shillaEntity);
            await Save();
        }

        public async Task<Shilla> Get(Expression<Func<Shilla, bool>> filter = null, bool tracked = true)
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

        public Task<List<Shilla>> GetAll(Expression<Func<Shilla, bool>> filter = null)
        {
            IQueryable<Shilla> queryable = _dbContext.Shillas;
            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }
            return await queryable.ToListAsync();
        }

        public async Task Remove(Shilla shillaEntity)
        {
            _dbContext.Shillas.Remove(shillaEntity);
            await Save();
        }

        public async Task Save()
        {
         await   _dbContext.SaveChangesAsync();
        }
    }
}
