using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BuckyBook.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext context;

        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }


        public async Task<IEnumerable<OrderDetail>> GetAllOrderDetailsByOrderId(int? orderId)
        {
            if (orderId == null)
            {
                return null;
            }

            else
            {
                var orderDetails =
             await context.OrderDetails
              .Include(p => p.Product)
              .Where(p => p.OrderId == orderId).ToListAsync();

                return orderDetails;
            }
        }
    }
}

