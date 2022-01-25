using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BuckyBook.Constant;
using BuckyBook.Models;
using BuckyBook.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BuckyBook.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    [Authorize]
    public class OrdersController : Controller
    {

        private readonly IUnitOfWork unitOfWork;

        [BindProperty]
        public OrderVM OrderVM { get; set; }

        public OrdersController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }

        // GET: /<controller>/
        public async Task<IActionResult> Index(string status)
        {
            IEnumerable<OrderHeader> orderHeaders;
            if(User.IsInRole(Roles.Admin) || User.IsInRole(Roles.Employer))
            {
                orderHeaders = await unitOfWork.OrderHeader.GetAllOrderHeaders(status);
            }

            else
            {
                // this means they should only see the orders that is linked to them
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                orderHeaders = await unitOfWork.OrderHeader.GetAllOrderHeaders(claim.Value, status);

            }

            return View(orderHeaders);
        }

        public async Task<IActionResult> Detail(int id)
        {
            OrderVM = new OrderVM()
            {
                OrderHeader = await unitOfWork.OrderHeader.GetOrderHeaderByOrderId(id),
                OrderDetail =await unitOfWork.OrderDetail.GetAllOrderDetailsByOrderId(id),
            };

            return View(OrderVM);
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin + "," + Roles.Employer)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateOrderDetail()
        {
            var orderHEaderFromDb = await unitOfWork.OrderHeader.GetAsync(OrderVM.OrderHeader.Id);

            orderHEaderFromDb.Name = OrderVM.OrderHeader.Name;
            orderHEaderFromDb.PhoneNumber = OrderVM.OrderHeader.PhoneNumber;
            orderHEaderFromDb.StreetAddress = OrderVM.OrderHeader.StreetAddress;
            orderHEaderFromDb.City = OrderVM.OrderHeader.City;
            orderHEaderFromDb.Carrier = OrderVM.OrderHeader.Carrier;
            orderHEaderFromDb.PostalCode = OrderVM.OrderHeader.PostalCode;

            if (OrderVM.OrderHeader.Carrier != null)
            {
                orderHEaderFromDb.Carrier = OrderVM.OrderHeader.Carrier;
            }
            if (OrderVM.OrderHeader.TrackingNumber != null)
            {
                orderHEaderFromDb.TrackingNumber = OrderVM.OrderHeader.TrackingNumber;
            }

            await unitOfWork.OrderHeader.UpdateAsync(orderHEaderFromDb);
            TempData["Success"] = "Order Details Updated Successfully.";
            return RedirectToAction("Detail", "Orders", new { id = orderHEaderFromDb.Id });
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin + "," + Roles.Employer)]
        [ValidateAntiForgeryToken]
        public IActionResult StartProcessing()
        {
            unitOfWork.OrderHeader.UpdateOrderStatue(OrderVM.OrderHeader.Id, StaticDetails.StatusInProcess);
            TempData["Success"] = "Order Details Updated Successfully.";
            return RedirectToAction("Detail", "Orders", new { id = OrderVM.OrderHeader.Id });
          
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin + "," + Roles.Employer)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShippedOrder()
        {
           
            var orderHEaderFromDb = await unitOfWork.OrderHeader.GetAsync(OrderVM.OrderHeader.Id);
            orderHEaderFromDb.TrackingNumber = Guid.NewGuid().ToString();
            orderHEaderFromDb.OrderStatus = StaticDetails.StatusShipped;
            orderHEaderFromDb.ShippingDate = DateTime.Now;

            if(orderHEaderFromDb.PaymentStatus == StaticDetails.PaymentStatusDelayedPayment)
            {
                orderHEaderFromDb.PaymentDueDate = DateTime.Now.AddDays(30);
            }
            await unitOfWork.OrderHeader.UpdateAsync(orderHEaderFromDb);
            TempData["Success"] = "Order Shipped Successfully.";
            return RedirectToAction("Detail", "Orders", new { id = OrderVM.OrderHeader.Id });
           
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin + "," + Roles.Employer)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CalcelOrder()
        {

            var orderHeader = await unitOfWork.OrderHeader.GetAsync(OrderVM.OrderHeader.Id);
            if(orderHeader.PaymentStatus == StaticDetails.PaymentStatusApproved)
            {
                var options = new RefundCreateOptions
                {
                    Reason = RefundReasons.RequestedByCustomer,
                    PaymentIntent = orderHeader.PaymentIntentId
                    
                };
                var service = new RefundService();
                Refund refund = service.Create(options);
                unitOfWork.OrderHeader.UpdateOrderStatue(orderHeader.Id, StaticDetails.StatusCancelled, StaticDetails.StatusRefunded);
            }

            else
            {
                // user cancelling their orders
                unitOfWork.OrderHeader.UpdateOrderStatue(orderHeader.Id, StaticDetails.StatusCancelled, StaticDetails.StatusCancelled);
            }
            
            TempData["Success"] = "Order Cancelled Successfully.";
            return RedirectToAction("Detail", "Orders", new { id = OrderVM.OrderHeader.Id });

        }
    }
}

