using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext context;

        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetAllCompanies()
        {
            IQueryable<Company> query = context.Companies;
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
