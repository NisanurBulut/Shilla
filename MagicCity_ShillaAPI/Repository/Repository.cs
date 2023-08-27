using MagicCity_ShillaAPI.Data;
using MagicCity_ShillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using MagicCity_ShillaAPI.Repository.IRepository;

namespace MagicCity_ShillaAPI.Repository
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private ShillaDbContext _dbContext;
        internal DbSet<T> dbSet;
        public Repository(ShillaDbContext dbContext)
        {
            _dbContext = dbContext;
            dbSet= _dbContext.Set<T>();
        }
        public async Task CreateAsync(T shillaEntity)
        {
            await dbSet.AddAsync(shillaEntity);
            await SaveAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true)
        {
            IQueryable<T> queryable = dbSet.AsQueryable();
            if (!tracked)
            {
                queryable = queryable.AsNoTracking();
            }
            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }
            return await queryable.FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> queryable =dbSet;
            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }
            return await queryable.ToListAsync();
        }

        public async Task RemoveAsync(T shillaEntity)
        {
            dbSet.Remove(shillaEntity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

      
    }
}
