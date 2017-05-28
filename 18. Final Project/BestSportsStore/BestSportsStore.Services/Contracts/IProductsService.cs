namespace BestSportsStore.Services.Contracts
{
    using Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public interface IProductsService
    {
        IQueryable<Product> GetAllByCategory(string categoryName, string subCategoryName = null, string query = null);

        IQueryable<Product> GetAllBySport(string sport = null, string query = null);

        IQueryable<Product> GetAllByBrand(string brand = null, string query = null);

        IQueryable<string> GetAllTitleAndContent();

        Product GetById(int id);

        IQueryable<Product> GetByIds(ICollection<int> ids);

        void AddLike(int productId, string userId);

        void AddComment(int productId, string userId, string content);
    }
}
