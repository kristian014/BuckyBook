using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Repositories
{
    public class CoverTypeRepository : GenericRepository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext context;

        public CoverTypeRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetAllCoverTypes()
        {
            IQueryable<CoverType> query = context.CoverTypes;
            return query.ToList().Select(s => new SelectListItem
            {
                Text = s.Name,
                Value = s.Id.ToString()
            });

        }
    
    }
}
