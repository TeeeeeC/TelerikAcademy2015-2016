namespace BestSportsStore.Services
{
    using Data.Models;
    using Data.Repositories;

    public abstract class BaseService
    {
        public BaseService(IRepository<Product> products)
        {
            this.Products = products;
        }

        public IRepository<Product> Products { get; private set; }
    }
}
