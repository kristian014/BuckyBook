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
            CoverType = new CoverTypeRepository(_context);
            Product = new ProductRepository(_context);
            Company = new CompanyRepository(_context);
        }
        public ICategoryRepository Category { get; private set; }

        public ICoverTypeRepository CoverType { get; private set; }

        public IProductRepository Product { get; private set; }

        public ICompanyRepository Company { get; private set; }
    }

}
