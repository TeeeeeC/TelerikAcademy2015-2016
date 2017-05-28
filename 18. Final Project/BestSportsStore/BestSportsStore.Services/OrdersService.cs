namespace BestSportsStore.Services
{
    using System.Linq;
    using Data.Models;
    using BestSportsStore.Services.Contracts;
    using Data.Repositories;

    public class OrdersService : BaseService, IOrdersService
    {
        private IRepository<Order> orders;

        public OrdersService(IRepository<Product> products, IRepository<Order> orders) 
            : base(products)
        {
            this.orders = orders;
        }

        public IQueryable<Order> GetByUserId(string userId)
        {
            return this.orders.All().Where(o => o.UserId == userId);
        }
    }
}
