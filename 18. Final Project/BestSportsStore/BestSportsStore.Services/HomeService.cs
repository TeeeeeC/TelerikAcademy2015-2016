namespace BestSportsStore.Services
{
    using System;
    using System.Linq;
    using Contracts;
    using Data.Models;
    using Data.Repositories;

    public class HomeService : BaseService, IHomeService
    {
        private readonly IRepository<Category> categories;
        private readonly IRepository<Sport> sports;
        private readonly IRepository<Brand> brands;

        public HomeService(IRepository<Product> products, IRepository<Category> categories,
            IRepository<Sport> sports, IRepository<Brand> brands)
            : base(products)
        {
            this.categories = categories;
            this.sports = sports;
            this.brands = brands;
        }

        public IQueryable<Category> GetCategories()
        {
            return this.categories.All();
        }

        public IQueryable<Product> GetTopProducts(int count)
        {
            return this.Products
                .All()
                .OrderByDescending(p => p.Likes.Count)
                .Take(count);
        }

        public IQueryable<Sport> GetSports()
        {
            return this.sports.All();
        }

        public IQueryable<Brand> GetBrands()
        {
            return this.brands.All();
        }
    }
}
