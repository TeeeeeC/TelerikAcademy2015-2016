namespace BestSportsStore.Services.Contracts
{
    using BestSportsStore.Data.Models;
    using System.Collections.Generic;
    public interface IShoppingService
    {
        ShoppingCart GetByUserId(string userId);

        void AddShoppingCart(int productId, int productSize, string userId);

        void UpdateShoppingCart(int productId, int productSize, string userId);

        void OrderProductBySize(int productId, int sizeId);

        void AddOrder(decimal totalPrice, string userId, IList<Product> products, string userCardId);

        void DeleteItemFromShoppingCart(int productId, int productSize, string userCartId);
    }
}
