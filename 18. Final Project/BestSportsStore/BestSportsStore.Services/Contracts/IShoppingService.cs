namespace BestSportsStore.Services.Contracts
{
    using BestSportsStore.Data.Models;

    public interface IShoppingService
    {
        ShoppingCart GetByUserId(string userId);

        void AddShoppingCart(int productId, int productSize, string userId);

        void UpdateShoppingCart(int productId, int productSize, string userId);

        void OrderProductBySize(int productId, int sizeId);

        void AddOrder(decimal totalPrice, string productsIds, string sizes, string userId, string userCardId, string titles);

        //void DeleteItemFromShoppingCart(int productId, int productSize, string userId);
    }
}
