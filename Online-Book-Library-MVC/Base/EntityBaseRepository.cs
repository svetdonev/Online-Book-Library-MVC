using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Online_Book_Library_MVC.Data;
using System.Linq.Expressions;

namespace Online_Book_Library_MVC.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly BookLibraryDbContext context;

        public EntityBaseRepository(BookLibraryDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await this.context.Set<T>().FirstOrDefaultAsync(a => a.Id == id);
            EntityEntry entityEntry = this.context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await this.context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = this.context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await this.context.Set<T>().FirstOrDefaultAsync(a => a.Id == id);
            return result;
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = this.context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await this.context.SaveChangesAsync();
        }
    }
}
