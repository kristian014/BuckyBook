using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Contracts
{
    public interface IApplicationUserRepository : IGenericRepository<ApplicationUser>
    {
    }
}
