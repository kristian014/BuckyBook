using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;

namespace BuckyBook.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
