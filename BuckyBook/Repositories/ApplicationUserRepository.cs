using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Repositories
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext context;

        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public ApplicationUser GetUserById(string userId)
        {
            var user = context.ApplicationUsers.FirstOrDefault(u => u.Id == userId);
            return user; 
        }
    }
}
