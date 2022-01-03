using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BuckyBook.Contracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        IEnumerable<SelectListItem> GetAllCategories();
    }
}
