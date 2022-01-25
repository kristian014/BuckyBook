using BuckyBook.Constant;
using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BuckyBook.Repositories
{
    public class OrderHeaderRepository : GenericRepository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext context;

        public OrderHeaderRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        // update order status
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

            context.SaveChanges();
        }

        
        public void UpdateStripePaymentId(int id, string sessionId, string paymentIntentId)
        {
            var orderFromDB = context.OrderHeaders.FirstOrDefault(u => u.Id == id);

            orderFromDB.PaymentDate = DateTime.Now;
            orderFromDB.SessionId = sessionId;
            orderFromDB.PaymentIntentId = paymentIntentId;

            context.SaveChanges();
        }

        // get all order headers by status 
        public async Task<IEnumerable<OrderHeader>> GetAllOrderHeaders(string status)
        {

            string staticDetail = GetStatus(status);
            if (!string.IsNullOrEmpty(status))
            {
                if(status == "pending")
                {
                    // company request

                    var orderHeaders = await GetOrderHeadersByPaymentStatus(staticDetail);
                    return orderHeaders;
                }

                else
                {
                    var orderHeaders =
                    await GetOrderHeadersByOrderStatus(staticDetail);
                    return orderHeaders;
                }
               
            }

            else
            {
                var orderHeaders =
                await context.OrderHeaders
                .Include(p => p.ApplicationUser).ToListAsync();
                return orderHeaders;

            }

        }

        // get orders by userId and status 
        public async Task<IEnumerable<OrderHeader>> GetAllOrderHeaders(string userId, string status)
        {

            string staticDetail = GetStatus(status);
            if (!string.IsNullOrEmpty(status))
            {
                if (status == "pending")
                {
                    // company request

                    var orderHeaders =
                  await GetOrderHeadersByPaymentStatus(staticDetail, userId);
                    return orderHeaders;
                }

                else
                {
                    var orderHeaders =
                    await GetOrderHeadersByOrderStatus(staticDetail, userId);
                    return orderHeaders;
                }

            }

            else
            {
                var orderHeaders =
                await context.OrderHeaders
                .Include(p => p.ApplicationUser)
                 .Where(p => p.ApplicationUserId == userId).ToListAsync();
                return orderHeaders;

            }

        }
        // het order by ID 
        public async Task<OrderHeader> GetOrderHeaderByOrderId(int? orderId)
        {
            if(orderId == null)
            {
                return null;
            }

            else
            {
                var orderHeader =
             await context.OrderHeaders
              .Include(p => p.ApplicationUser)
              .FirstOrDefaultAsync(p => p.Id == orderId);

                return orderHeader;
            }

        }

        // get order by user ID
        public async Task<IEnumerable<OrderHeader>> GetAllOrderHeaderByUserId(string userId)
        {
            var orderHeaders =
              await context.OrderHeaders
               .Include(p => p.ApplicationUser)
                .Where(p => p.ApplicationUserId == userId).ToListAsync();
            return orderHeaders;


        }

        private async Task<List<OrderHeader>> GetOrderHeadersByPaymentStatus(string staticDetail)
        {
            var orderHeaders =
            await context.OrderHeaders
                 .Include(p => p.ApplicationUser)
                 .Where(p => p.PaymentStatus == staticDetail).ToListAsync();

            return orderHeaders;
        }

        private async Task<List<OrderHeader>> GetOrderHeadersByPaymentStatus(string staticDetail, string userId)
        {
            var orderHeaders =
            await context.OrderHeaders
                 .Include(p => p.ApplicationUser)
                 .Where(p => p.PaymentStatus == staticDetail && p.ApplicationUserId == userId).ToListAsync();

            return orderHeaders;
        }

     
        private async Task<List<OrderHeader>> GetOrderHeadersByOrderStatus(string staticDetail, string userId)
        {
            var orderHeaders =
            await context.OrderHeaders
                 .Include(p => p.ApplicationUser)
                 .Where(p => p.OrderStatus == staticDetail && p.ApplicationUserId == userId).ToListAsync();

            return orderHeaders;
        }

        private async Task<List<OrderHeader>> GetOrderHeadersByOrderStatus(string staticDetail)
        {
            var orderHeaders =
            await context.OrderHeaders
                 .Include(p => p.ApplicationUser)
                 .Where(p => p.OrderStatus == staticDetail).ToListAsync();

            return orderHeaders;
        }


        private string GetStatus(string status)
        {
           switch(status)
            {
                case "pending":
                    return StaticDetails.PaymentStatusDelayedPayment;
                case "inprocess":
                    return StaticDetails.StatusInProcess;
                case "completed":
                    return StaticDetails.StatusShipped;
                case "approved":
                    return StaticDetails.StatusApproved;
                default:
                    return "";
            }
        }

      
    }
}

