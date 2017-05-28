namespace BestSportsStore.Services.Contracts
{
    using Data.Models;
    using System.Linq;

    public interface IHomeService
    {
        IQueryable<Product> GetTopProducts(int count);

        IQueryable<Category> GetCategories();

        IQueryable<Sport> GetSports();

        IQueryable<Brand> GetBrands();
    }
}
