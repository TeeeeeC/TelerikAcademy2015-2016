namespace BestSportsStore.Services.Contracts
{
    using System;
    using System.Linq;
    using Contracts;
    using Data.Models;
    using Data.Repositories;

    public class ProductsService : BaseService, IProductsService
    {
        public ProductsService(IRepository<Product> products)
            : base(products)
        {
        }

        public IQueryable<Product> GetAllByCategory(string categoryName, string subCategoryName = null)
        {
            if(subCategoryName != null)
            {
                return this.Products.All()
                .Where(p => p.Category.Name == categoryName && p.SubCategory.Name == subCategoryName);
            }

            return this.Products.All()
                .Where(p => p.Category.Name == categoryName);
        }
    }
}
