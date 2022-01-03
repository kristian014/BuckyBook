using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BuckyBook.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task UpdateProductAsync(Product entity)
        {
            var entityFromDb = context.Products.FirstOrDefault(u => u.Id == entity.Id);
            if(entityFromDb != null)
            {
                entityFromDb.Title = entity.Title;
                entityFromDb.ISBN = entity.ISBN;
                entityFromDb.Price = entity.Price;
                entityFromDb.Price50 = entity.Price50;
                entityFromDb.ListPrice = entity.ListPrice;
                entityFromDb.Price100 = entity.Price100;
                entityFromDb.Description = entity.Description;
                entityFromDb.CategoryId = entity.CategoryId;
                entityFromDb.Author = entity.Author;
                entityFromDb.CoverTypeId = entity.CoverTypeId;

                if(entity.ImageUrl != null)
                {
                    entityFromDb.ImageUrl = entity.ImageUrl;
                }

            }
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProduct(string searchString)
        {
           if (!string.IsNullOrEmpty(searchString))
            {
                var products =
                   await context.Products
                    .Include(p => p.Category)
                    .Include(p => p.CoverType)
                    .Where(p => p.Title.Contains(searchString)).ToListAsync();
                return products;
            }

            else
            {
                var products =
                  await context.Products
                   .Include(p => p.Category)
                   .Include(p => p.CoverType).ToListAsync();
                return products;
            }

            //var products = context.Products.Include(p => p.Category).Include(p => p.CoverType);

        }

        public async Task<Product> GetProductWithId(int? id)
        {
            if (id == null)
            {
                return null;
            }

            else
            {
                var product = await context.Products
                .Include(p => p.Category)
                .Include(p => p.CoverType)
                .FirstOrDefaultAsync(m => m.Id == id);

                return product;
            }
            
        }
    }
}
