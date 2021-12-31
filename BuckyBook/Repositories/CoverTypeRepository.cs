using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;

namespace BuckyBook.Repositories
{
    public class CoverTypeRepository : GenericRepository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext context;

        public CoverTypeRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
