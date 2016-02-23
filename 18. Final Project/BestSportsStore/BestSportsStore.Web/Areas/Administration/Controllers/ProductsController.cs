namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Models;
    using System.Linq;
    using System.Web.Mvc;
    using Web.Models.Menu.Brand;
    using Web.Models.Menu.Category;
    using Web.Models.Sport;

    public class ProductsController : BaseAdminController
    {
        private IRepository<Product> products;
        private IRepository<Brand> brands;
        private IRepository<Sport> sports;
        private IRepository<Category> categories;
        private IRepository<SubCategory> subCategories;

        public ProductsController(IRepository<Product> products, IRepository<Brand> brands,
            IRepository<Sport> sports, IRepository<Category> categories, IRepository<SubCategory> subCategories)
        {
            this.products = products;
            this.brands = brands;
            this.sports = sports;
            this.categories = categories;
            this.subCategories = subCategories;
        }

        public ActionResult Index()
        {
            ViewData["brands"] = this.brands.All().To<BrandViewModel>().ToList();
            ViewData["sports"] = this.sports.All().To<SportViewModel>().ToList();
            ViewData["categories"] = this.categories.All().To<CategoryViewModel>().ToList();
            ViewData["subCategories"] = this.subCategories.All().To<SubCategoryViewModel>().ToList();

            return View();
        }

        public JsonResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var products = this.products
               .All().To<ProductGridViewModel>();

            return Json(products.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update([DataSourceRequest] DataSourceRequest request, ProductGridViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productEntry = this.products.GetById(product.Id);
                productEntry.Title = product.Title;
                productEntry.Content = product.Content;
                productEntry.Price = product.Price;
                productEntry.ImageUrl = product.ImageUrl;
                productEntry.BrandId = product.Brand.Id;
                productEntry.CategoryId = product.Category.Id;
                productEntry.SportId = product.Sport.Id;
                productEntry.SubCategoryId = product.SubCategory.Id;

                this.products.Update(productEntry);
                this.products.SaveChanges();
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Create([DataSourceRequest] DataSourceRequest request, ProductGridViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productToAdd = new Product()
                {
                    Title = product.Title,
                    Content = product.Content,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    BrandId = product.Brand.Id,
                    CategoryId = product.Category.Id,
                    SportId = product.Sport.Id,
                    SubCategoryId = product.SubCategory.Id
                };

                this.products.Add(productToAdd);
                this.products.SaveChanges();
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Destroy([DataSourceRequest] DataSourceRequest request, ProductGridViewModel product)
        {
            var productEntry = this.products.All().FirstOrDefault(p => p.Id == product.Id);
            this.products.Delete(productEntry);
            this.products.SaveChanges();

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }
    }
}