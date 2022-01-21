using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BuckyBook.Constant;
using BuckyBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BuckyBook.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    [Authorize]
    public class OrdersController : Controller
    {

        private readonly IUnitOfWork unitOfWork;

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
    }
}

