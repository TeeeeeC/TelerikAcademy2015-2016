namespace BestSportsStore.Services.Contracts
{
    using Data.Models;
    using System.Linq;

    public interface IProductsService
    {
        IQueryable<Product> GetAllByCategory(string categoryName, string subCategoryName = null);
    }
}
