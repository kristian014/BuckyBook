using BuckyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuckyBook.Contracts
{
    public interface IShoppingCartRepository : IGenericRepository<ShoppingCart>
    {
        ShoppingCart GetShoppingCartWithUserIdAndProductId(string userId, int productId);
        int IncrementCount(ShoppingCart shoppingCart, int count);
        int DecrementCount(ShoppingCart shoppingCart, int count);
        Task<IEnumerable<ShoppingCart>> GetAllShoppingCartByUserId(string UserId);
    }

}
