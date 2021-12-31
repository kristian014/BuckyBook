namespace BuckyBook.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int? id);
        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task RemoveRangeAsync(IEnumerable<T> entities);
        Task DeleteAsync(int id);
        Task<bool> Exists(int id);

    }
}
