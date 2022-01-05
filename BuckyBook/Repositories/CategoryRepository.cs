using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetAllCategories()
        {
            IQueryable<Category> query = context.Categories;
            if (query == null)
            {
                return Enumerable.Empty<SelectListItem>();
            }
            return query.ToList().Select(s => new SelectListItem
            {
                Text = s.Name,
                Value = s.Id.ToString()
            });

        }
    }
}

