using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Repositories
{
    public class OrderHeaderRepository : GenericRepository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext context;

        public OrderHeaderRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public void UpdateOrderStatue(int id, string orderStatus, string? paymentStatus = null)
        {
            var orderFromDB = context.OrderHeaders.FirstOrDefault(u => u.Id == id);

            if(orderFromDB != null)
            {
                orderFromDB.OrderStatus = orderStatus;

                if(paymentStatus != null)
                {
                    orderFromDB.PaymentStatus = paymentStatus;
                }
            }
        }
    }
}

