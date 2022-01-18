using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BuckyBook.Contracts
{
    public interface IOrderHeaderRepository : IGenericRepository<OrderHeader>
    {
        void UpdateOrderStatue(int id, string orderStatus, string? paymentStatus=null);
    }
}
