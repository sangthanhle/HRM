using HRM.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HRM.DataAccess.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        internal readonly ApplicationDbContext _Dbcontext;
        private readonly DbSet<TEntity> dbSet;

        public GenericRepository(ApplicationDbContext Dbcontext)
        {
            this._Dbcontext = Dbcontext;
            this.dbSet = Dbcontext.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
        }
        public async Task UpdateAsync(TEntity entity)
        {
            dbSet.Attach(entity);
            _Dbcontext.Entry(entity).State = EntityState.Modified;
        }
        public async Task DeleteAsync(object id)
        {
            TEntity entityToDelete = await dbSet.FindAsync(id);
            if (entityToDelete != null)
                dbSet.Remove(entityToDelete);
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<IEnumerable<TEntity>> GetPaginationAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "",
            int? pageIndex = null,
            int? pageSize = null)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (pageIndex.HasValue && pageSize.HasValue)
            {
                int validPageIndex = pageIndex.Value > 0 ? pageIndex.Value - 1 : 0;
                int validPageSize = pageSize.Value > 0 ? pageSize.Value : 10;

                query = query.Skip(validPageIndex * validPageSize).Take(validPageSize);
            }

            return await query.ToListAsync();
        }

       
    }
}
