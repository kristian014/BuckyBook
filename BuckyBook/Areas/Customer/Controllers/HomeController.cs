using AutoMapper;
using BuckyBook.Models;
using BuckyBook.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace BuckyBook.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;

        public HomeController(IMapper mapper, ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var products = await unitOfWork.Product.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Details(int productId)
        {
            var product = await unitOfWork.Product.GetProductWithId(productId);

            if (product == null)
            {
                return NotFound();
            }
            ShoppingCart shoppingCart = new()
            {
                Count = 1,
                ProductId = productId,
                Product = product,
            };

           // var productVM = mapper.Map<ProductVM>(product);
            return View(shoppingCart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Details(ShoppingCart shoppingCart)
        {
            // create the shopping cart obj 

            // you can use the claim identity to retrieve the 
            // user ID 

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            shoppingCart.ApplicationUserId = claim.Value;
            ShoppingCart shoppingCartFromDB = unitOfWork.ShoppingCart.GetShoppingCartWithUserIdAndProductId(shoppingCart.ApplicationUserId, shoppingCart.ProductId);

            if(shoppingCartFromDB == null)
            {
                await unitOfWork.ShoppingCart.AddAsync(shoppingCart);
            }

            else
            {
                // update the shopping cart 
                unitOfWork.ShoppingCart.IncrementCount(shoppingCartFromDB, shoppingCart.Count);
            }

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}