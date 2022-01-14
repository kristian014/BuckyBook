using BuckyBook.Contracts;
using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BuckyBook.Repositories
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext context;

        public ShoppingCartRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public int DecrementCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Count -= count;
            context.SaveChanges();
            return shoppingCart.Count;
        }

        public ShoppingCart GetShoppingCartWithUserIdAndProductId(string userId, int productId)
        {
                var shoppingCart = context.ShoppingCarts
               .FirstOrDefault(m => m.ApplicationUserId == userId && m.ProductId == productId);

                return shoppingCart;
          
        }
        public async Task<IEnumerable<ShoppingCart>> GetAllShoppingCartByUserId(string userId)
        {
                var shoppingCart =
                  await context.ShoppingCarts
                   .Include(p => p.Product)
                    .Where(p => p.ApplicationUserId == userId).ToListAsync();
            return shoppingCart;
         
            //var products = context.Products.Include(p => p.Category).Include(p => p.CoverType);

        }


        public int IncrementCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Count += count;
            context.SaveChanges();
            return shoppingCart.Count;
        }
    }
}
