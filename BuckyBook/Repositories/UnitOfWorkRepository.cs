using BuckyBook.Contracts;
using BuckyBook.Data;

namespace BuckyBook.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
       
        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            this._context = context;
            Category = new CategoryRepository(_context);
        }
        public ICategoryRepository Category { get; private set; }

    }
}
