using BuckyBook.Models;

namespace BuckyBook.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task UpdateProductAsync(Product entity);
        Task<IEnumerable<Product>> GetAllProduct(string searchString);

        Task<Product> GetProductWithId(int? id);
    }
}
