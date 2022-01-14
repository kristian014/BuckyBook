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
            };
            foreach(var cart in ShoppingCartVM.ListCart)
            {
                cart.Price = GetPriceBasedOnQuantity(cart.Count, cart.Product.Price, cart.Product.Price50, cart.Product.Price100);
                ShoppingCartVM.CartTotal += (cart.Price * cart.Count);
            }
            return View(ShoppingCartVM);
        }

        public async Task<IActionResult> Summary()
        {
           return View();
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
