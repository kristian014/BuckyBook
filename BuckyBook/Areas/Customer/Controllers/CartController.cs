using BuckyBook.Constant;
using BuckyBook.Models;
using BuckyBook.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BuckyBook.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public ShoppingCartVM ShoppingCartVM { get; set; }
        public int OrderTotal { get; set; }

        public CartController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        // [AllowAnonymous]
        public async Task<IActionResult> IndexAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            ShoppingCartVM = new ShoppingCartVM()
            {
                ListCart = await unitOfWork.ShoppingCart.GetAllShoppingCartByUserId(claim.Value),
                OrderHeader = new()
            };
            foreach(var cart in ShoppingCartVM.ListCart)
            {
                cart.Price = GetPriceBasedOnQuantity(cart.Count, cart.Product.Price, cart.Product.Price50, cart.Product.Price100);
                ShoppingCartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
            }
            return View(ShoppingCartVM);
        }

        [Authorize]
        public async Task<IActionResult> Summary()
        {

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            ShoppingCartVM = new ShoppingCartVM()
            {
                ListCart = await unitOfWork.ShoppingCart.GetAllShoppingCartByUserId(claim.Value),
                OrderHeader = new()
            };

            ShoppingCartVM.OrderHeader.ApplicationUser = unitOfWork.ApplicationUser.GetUserById(claim.Value);

            ShoppingCartVM.OrderHeader.Name = ShoppingCartVM.OrderHeader.ApplicationUser.Name;
            ShoppingCartVM.OrderHeader.PhoneNumber = ShoppingCartVM.OrderHeader.ApplicationUser.PhoneNumber;
            ShoppingCartVM.OrderHeader.StreetAddress = ShoppingCartVM.OrderHeader.ApplicationUser.StreetAddress;
            ShoppingCartVM.OrderHeader.City = ShoppingCartVM.OrderHeader.ApplicationUser.City;
            ShoppingCartVM.OrderHeader.State = ShoppingCartVM.OrderHeader.ApplicationUser.State;
            ShoppingCartVM.OrderHeader.PostalCode = ShoppingCartVM.OrderHeader.ApplicationUser.PostalCode;



            foreach (var cart in ShoppingCartVM.ListCart)
            {
                cart.Price = GetPriceBasedOnQuantity(cart.Count, cart.Product.Price, cart.Product.Price50, cart.Product.Price100);
                ShoppingCartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
            }

            return View(ShoppingCartVM);
        }


        [HttpPost]
        [ActionName("Summary")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SummaryPost(ShoppingCartVM ShoppingCartVM)
        {

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            ShoppingCartVM.ListCart = await unitOfWork.ShoppingCart.GetAllShoppingCartByUserId(claim.Value);
            ShoppingCartVM.OrderHeader.PaymentStatus = StaticDetails.PaymentStatusPending;
            ShoppingCartVM.OrderHeader.OrderStatus = StaticDetails.StatusPending;
            ShoppingCartVM.OrderHeader.OrderDate = DateTime.Now;
            ShoppingCartVM.OrderHeader.ApplicationUserId = claim.Value;


            foreach (var cart in ShoppingCartVM.ListCart)
            {
                cart.Price = GetPriceBasedOnQuantity(cart.Count, cart.Product.Price, cart.Product.Price50, cart.Product.Price100);
                ShoppingCartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
            }

            await unitOfWork.OrderHeader.AddAsync(ShoppingCartVM.OrderHeader);

            var orderDetails = new List<OrderDetail>();

            foreach (var cart in ShoppingCartVM.ListCart)
            {
                orderDetails.Add(new OrderDetail
                {
                    ProductId = cart.ProductId,
                    OrderId = ShoppingCartVM.OrderHeader.Id,
                    Price = cart.Price,
                    Count = cart.Count
                });
                await unitOfWork.OrderDetail.AddRangeAsync(orderDetails);
            }
            // clear shopping cart

            await unitOfWork.ShoppingCart.RemoveRangeAsync(ShoppingCartVM.ListCart);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Plus(int cartId)
        {
            var shoppingCart = await unitOfWork.ShoppingCart.GetAsync(cartId);
            unitOfWork.ShoppingCart.IncrementCount(shoppingCart, 1);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Minus(int cartId)
        {
            var shoppingCart = await unitOfWork.ShoppingCart.GetAsync(cartId);

            if(shoppingCart.Count <= 1)
            {
                await unitOfWork.ShoppingCart.DeleteAsync(shoppingCart.Id);
            }

            else
            {
                unitOfWork.ShoppingCart.DecrementCount(shoppingCart, 1);
            }

            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Remove(int cartId)
        {
            await unitOfWork.ShoppingCart.DeleteAsync(cartId);
            return RedirectToAction(nameof(Index));
        }
        private double GetPriceBasedOnQuantity(double quantity, double price, double price50, double price100)
        {
            if(quantity <= 50)
            {
                return price;
            }

            else
            {
                if(quantity <= 100)
                {
                    return price50;
                }

                return price; 
            }
        }
    }
}
