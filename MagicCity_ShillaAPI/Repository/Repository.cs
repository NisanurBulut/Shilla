using MagicShilla_Utility.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using MagicCity_ShillaAPI.Repository.IRepository;

namespace MagicCity_ShillaAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ShillaDbContext _dbContext;
        internal DbSet<T> dbSet;
        public Repository(ShillaDbContext dbContext)
        {
            _dbContext = dbContext;
            dbSet = _dbContext.Set<T>();
        }
        public async Task CreateAsync(T shillaEntity)
        {
            await dbSet.AddAsync(shillaEntity);
            await SaveAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string? includeProperties = null)
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
            if (includeProperties != null)
            {
                foreach (var includePropItem in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    queryable.Include(includePropItem);
                }
            }
            return await queryable.FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, int PageSize = 0, int PageNumber = 1)
        {
            IQueryable<T> queryable = dbSet;
            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }

            if (PageSize > 0)
            {
                PageSize = (PageSize > 10) ? 100 : PageSize;
                queryable = queryable.Skip(PageSize * (PageNumber - 1)).Take(PageSize);
            }

            if (includeProperties != null)
            {
                foreach (var includePropItem in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    queryable.Include(includePropItem);
                }
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
