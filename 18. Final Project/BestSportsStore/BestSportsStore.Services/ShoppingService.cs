namespace BestSportsStore.Services
{
    using Contracts;
    using Data.Models;
    using Data.Repositories;
    using System;
    using System.Linq;
    using System.Text;

    public class ShoppingService : BaseService, IShoppingService
    {
        private IRepository<ShoppingCart> shoppingCarts;
        private IRepository<Order> orders;

        public ShoppingService(IRepository<ShoppingCart> shoppingCarts,
            IRepository<Product> products, IRepository<Order> orders)
            : base(products)
        {
            this.shoppingCarts = shoppingCarts;
            this.orders = orders;
        }

        public void AddShoppingCart(int productId, int productSize, string userId)
        {
            this.shoppingCarts.Add(new ShoppingCart
            {
                UserId = userId,
                ProductIds = productId.ToString() + ",",
                Sizes = productSize.ToString() + ",",
                ProductsCount = 1
            });

            this.shoppingCarts.SaveChanges();
        }

        public ShoppingCart GetByUserId(string userId)
        {
            return this.shoppingCarts.All().FirstOrDefault(s => s.UserId == userId);
        }

        public void UpdateShoppingCart(int productId, int productSize, string userId)
        {
            var cart = this.GetByUserId(userId);
            var productsIds = new StringBuilder(cart.ProductIds);
            productsIds.Append(productId);
            productsIds.Append(',');
            cart.ProductIds = productsIds.ToString();

            var sizes = new StringBuilder(cart.Sizes);
            sizes.Append(productSize);
            sizes.Append(',');
            cart.Sizes = sizes.ToString();

            cart.ProductsCount++;

            this.shoppingCarts.SaveChanges();
        }

        public void OrderProductBySize(int productId, int sizeId)
        {
            var product = this.Products.All().FirstOrDefault(p => p.Id == productId);
            var size = product.Sizes.FirstOrDefault(s => s.Value == sizeId);
            product.Sizes.Remove(size);

            if(product.Sizes.Count == 0)
            {
                this.Products.Delete(product.Id);
            }

            this.Products.SaveChanges();

        }

        public void AddOrder(decimal totalPrice, string productsIds, string sizes, string userId, string userCardId, string titles)
        {
            var cart = this.shoppingCarts.All().FirstOrDefault(c => c.UserId == userCardId);
            cart.ProductIds = string.Empty;
            cart.Sizes = string.Empty;
            cart.ProductsCount = 0;
            this.shoppingCarts.SaveChanges();

            var order = new Order
            {
                TotalPrice = totalPrice,
                ProductIds = productsIds,
                ProductSizes = sizes,
                ProductTitles = titles,
                UserId = userId
            };

            this.orders.Add(order);
            this.orders.SaveChanges();
        }
    }
}
