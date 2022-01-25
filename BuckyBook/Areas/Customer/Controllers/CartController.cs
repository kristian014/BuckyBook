using BuckyBook.Constant;
using BuckyBook.Models;
using BuckyBook.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using System.Security.Claims;

namespace BuckyBook.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public ShoppingCartVM ShoppingCartVM { get; set; }
        private readonly IEmailSender _emailSender;
        public int OrderTotal { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(UserManager<ApplicationUser> userManager, IEmailSender emailSender, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _emailSender = emailSender;

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
            ShoppingCartVM.OrderHeader.ApplicationUserId = ShoppingCartVM.OrderHeader.ApplicationUser.Id;
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
        public async Task<IActionResult> SummaryPost(OrderHeader OrderHeader)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            ShoppingCartVM ShoppingCartVM = new ShoppingCartVM();
            ShoppingCartVM.ListCart = await unitOfWork.ShoppingCart.GetAllShoppingCartByUserId(claim.Value);
            ShoppingCartVM.OrderHeader = OrderHeader;
            ShoppingCartVM.OrderHeader.OrderDate = DateTime.Now;
            ShoppingCartVM.OrderHeader.ApplicationUserId = claim.Value;


            if (!ModelState.IsValid)
            {
                return View(ShoppingCartVM);
            }

           // loop through the list of shopping cart 
            foreach (var shoppingCart in ShoppingCartVM.ListCart)
            {
                // each selected product has a price. And these prices is calculated based on the number of count
                // GetPriceBasedOnQuantity checks to make sure the right price is returned based on the quantity
                shoppingCart.Price = GetPriceBasedOnQuantity(shoppingCart.Count, shoppingCart.Product.Price, shoppingCart.Product.Price50, shoppingCart.Product.Price100);

                // This set the order total price 
                ShoppingCartVM.OrderHeader.OrderTotal += (shoppingCart.Price * shoppingCart.Count);
            }

            // if the user is a company user
            // change the payment status to delayed payment
            // And keep the status approved 
            if (User.IsInRole(Roles.Company))
            {
                // company user
                ShoppingCartVM.OrderHeader.PaymentStatus = StaticDetails.PaymentStatusDelayedPayment;
                ShoppingCartVM.OrderHeader.OrderStatus = StaticDetails.StatusApproved;

            }

            else
            {
                    // If it a user, keep all status pending until it's approved by admin 
                ShoppingCartVM.OrderHeader.PaymentStatus = StaticDetails.PaymentStatusPending;
                ShoppingCartVM.OrderHeader.OrderStatus = StaticDetails.StatusPending;
            }
              
            await unitOfWork.OrderHeader.AddAsync(ShoppingCartVM.OrderHeader);

            // order details tells us more information about the product
            // i.e the single price of the product
            // order id
            // count etc 

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
               
            }

           
            // add range is used to add multiple entries to the db instead of multiple db calls 
            await unitOfWork.OrderDetail.AddRangeAsync(orderDetails);

            // if the role isn't a company role, only then we want to procedd to stripe checkout 
            if (!User.IsInRole(Roles.Company))
            {
                // stripe settings
                var domain = "https://localhost:7260/";
                var options = new SessionCreateOptions
                {

                    PaymentMethodTypes = new List<string>
                {
                    "card",
                },

                    LineItems = new List<SessionLineItemOptions>(),

                    Mode = "payment",
                    // page to display to confirm payment 
                    SuccessUrl = domain + $"customer/cart/OrderConfirmation?id={ShoppingCartVM.OrderHeader.Id}",
                    CancelUrl = domain + $"customer/cart/index",
                };

                foreach (var item in ShoppingCartVM.ListCart)
                {
                    var sessionLineItem = new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = (long)(item.Price * 100),
                            Currency = "usd",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = item.Product.Title,
                            },

                        },
                        Quantity = item.Count,
                    };
                    options.LineItems.Add(sessionLineItem);
                }

                var service = new SessionService();
                Session session = service.Create(options);
                unitOfWork.OrderHeader.UpdateStripePaymentId(ShoppingCartVM.OrderHeader.Id, session.Id, session.PaymentIntentId);
                Response.Headers.Add("Location", session.Url);
                return new StatusCodeResult(303);
            }

            else
            {
                // this is a company user
                // just redirect because a company user can pay for the items later
                // redirect to the order confirmation page and pass the id

                return RedirectToAction("OrderConfirmation", "Cart", new { id = ShoppingCartVM.OrderHeader.Id });
            }
        }



        /*
            Now that will have different users that can assess the order confirmation page
            It good to check the payment status that we are getting back from stripe
            
            we know if the payment status us delayed, then it's a company user and if it's pending then its a user

        However instead of doing the check with just the payment status, we can also do the check by user 
         * 
         */


        // this will be called when a payment has been made 
        public async Task<IActionResult> OrderConfirmation(int id)
        {
            // the orderheader has been passed through the SummaryPost controller method  
            OrderHeader orderHeader = await unitOfWork.OrderHeader.GetOrderHeaderByOrderId(id);
            if (!User.IsInRole(Roles.Company) && orderHeader.PaymentStatus != StaticDetails.PaymentStatusDelayedPayment)
            {
                var service = new SessionService();
                Session session = service.Get(orderHeader.SessionId);

                if (session.PaymentStatus.ToLower() == "paid")
                {
                    unitOfWork.OrderHeader.UpdateOrderStatue(id, StaticDetails.StatusApproved, StaticDetails.PaymentStatusApproved);
                }

            }

            await _emailSender.SendEmailAsync(orderHeader.ApplicationUser.Email, "New Order - Bucky Book", "<p> Thank you for placing a new order </p>");
            var shoppingCarts = await unitOfWork.ShoppingCart.GetAllShoppingCartByUserId(orderHeader.ApplicationUserId);
            await unitOfWork.ShoppingCart.RemoveRangeAsync(shoppingCarts);
            return View(id);
        }

        //
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
