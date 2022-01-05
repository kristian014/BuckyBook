using AutoMapper;
using BuckyBook.Models;
using BuckyBook.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            return View(await unitOfWork.Product.GetAllAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await unitOfWork.Product.GetProductWithId(id);

            if (product == null)
            {
                return NotFound();
            }
            ShoppingCart shoppingCart = new()
            {
                Count = 1,
                Product = product,
            };

           // var productVM = mapper.Map<ProductVM>(product);
            return View(shoppingCart);
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