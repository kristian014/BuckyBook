using BuckyBook.Contracts;
using BuckyBook.Data;
using Microsoft.EntityFrameworkCore;

namespace BuckyBook.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        //internal DbSet<T> dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
            //this.dbSet = context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await context.AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            context.RemoveRange(entities);
            await context.SaveChangesAsync();
        }
    }
}
