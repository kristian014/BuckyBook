using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Contracts
{
    public interface ICoverTypeRepository : IGenericRepository<CoverType>
    {
        IEnumerable<SelectListItem> GetAllCoverTypes();
    }
}
