using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BuckyBook.Contracts
{
    public interface IOrderHeaderRepository : IGenericRepository<OrderHeader>
    {
        void UpdateOrderStatue(int id, string orderStatus, string? paymentStatus=null);

        void UpdateStripePaymentId(int id, string SessionId, string paymentIntentId);

        Task<IEnumerable<OrderHeader>> GetAllOrderHeaders(string status);

        Task<IEnumerable<OrderHeader>> GetAllOrderHeaderByUserId(string UserId);

        Task<IEnumerable<OrderHeader>> GetAllOrderHeaders(string userId, string UserId);

        Task<OrderHeader> GetOrderHeaderByOrderId(int? orderId);


    }
}
