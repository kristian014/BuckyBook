using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Contracts
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        IEnumerable<SelectListItem> GetAllCompanies();
    }
}
