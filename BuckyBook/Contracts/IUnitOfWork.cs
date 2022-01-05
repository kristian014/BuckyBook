﻿using BuckyBook.Contracts;

namespace BuckyBook
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }

        ICompanyRepository Company { get; }
    }
}
