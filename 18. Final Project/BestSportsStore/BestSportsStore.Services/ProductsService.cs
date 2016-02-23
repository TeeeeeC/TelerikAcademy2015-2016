namespace BestSportsStore.Services.Contracts
{
    using System;
    using System.Linq;
    using Contracts;
    using Data.Models;
    using Data.Repositories;
    using System.Collections.Generic;
    using Data;

    public class ProductsService : BaseService, IProductsService
    { 
        private const int PageSize = 5;

        private IBestSportsStoreDbContext context;

        public ProductsService(IRepository<Product> products, IBestSportsStoreDbContext context)
            : base(products)
        {
            this.context = context;
        }

        public IQueryable<Product> GetAllByCategory(string categoryName, string subCategoryName = null, string query = null)
        {
            if (subCategoryName != null && subCategoryName != string.Empty)
            {
                if (query != string.Empty)
                {
                    return this.Products.All()
                    .Where(p => p.Category.Name == categoryName && p.SubCategory.Name == subCategoryName
                        && (p.Title.Contains(query) || p.Content.Contains(query)));
                }

                return this.Products.All()
                    .Where(p => p.Category.Name == categoryName && p.SubCategory.Name == subCategoryName);
            }


            if (query != string.Empty)
            {
                return this.Products.All()
                .Where(p => p.Category.Name == categoryName && (p.Title.Contains(query) || p.Content.Contains(query)));
            }

            return this.Products.All()
                .Where(p => p.Category.Name == categoryName);
        }

        public IQueryable<Product> GetAllBySport(string sport = null, string query = null)
        {
            if (sport == null)
            {
                if(query != null)
                {
                    return this.Products.All().Where(p => p.Title.Contains(query) || p.Content.Contains(query));
                }

                return this.Products.All();
            }

            if (query != null)
            {
                return this.Products.All()
                    .Where(p => p.Sport.Name == sport && (p.Title.Contains(query) || p.Content.Contains(query)));
            }


            return this.Products.All()
                .Where(p => p.Sport.Name == sport);
        }

        public IQueryable<Product> GetAllByBrand(string brand = null, string query = null)
        {
            if (brand == null)
            {
                if (query != null)
                {
                    return this.Products.All()
                        .Where(p => p.Title.Contains(query) || p.Content.Contains(query));
                }

                return this.Products.All();
            }

            if (query != null)
            {
                return this.Products.All()
                    .Where(p => p.Brand.Name == brand && (p.Title.Contains(query) || p.Content.Contains(query)));
            }

            return this.Products.All()
                .Where(p => p.Brand.Name == brand);
        }

        public IQueryable<string> GetAllTitleAndContent()
        {
            List<string> data = this.Products.All().Select(p => p.Title).ToList();
            data.AddRange(this.Products.All().Select(p => p.Content).ToList());

            return data.AsQueryable();
        }

        public Product GetById(int id)
        {
            return this.Products.All().FirstOrDefault(p => p.Id == id);
        }

        public IQueryable<Product> GetByIds(ICollection<int> ids)
        {
            var sql = "SELECT * FROM Products WHERE ID IN (" + string.Join(", ", ids) + ")";
            
            return this.context.Set<Product>().SqlQuery(sql).AsQueryable();
        }

        public void AddLike(int productId, string userId)
        {
            var product = this.Products.All().FirstOrDefault(p => p.Id == productId);
            product.Likes.Add(new Like() { UserId = userId });
            this.Products.SaveChanges();
        }

        public void AddComment(int productId, string userId, string content)
        {
            var product = this.Products.All().FirstOrDefault(p => p.Id == productId);
            product.Comments.Add(new Comment() { UserId = userId, CreatedOn = DateTime.Now, Content = content });
            this.Products.SaveChanges();
        }
    }
}
