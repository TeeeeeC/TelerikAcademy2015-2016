namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Web.Models.Menu.Category;
    using Web.Models.Product;

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

        public ActionResult Index(int page = 1)
        {
            var pagesCount = this.products.All().Count();
            var viewModel = new ProductGridViewModel
            {
                CurrentPage = page,
                PagesCount = (int)Math.Ceiling(pagesCount / (decimal)PageSize),
                Products = this.products.All().To<ProductViewModel>().OrderBy(p => p.Price).Skip((page - 1) * PageSize).Take(PageSize).ToList()
            };

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["categories"] = this.categories.All().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            ViewData["subCategories"] = this.subCategories.All().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            ViewData["brands"] = this.brands.All().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            ViewData["sports"] = this.sports.All().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var productDb = this.Mapper.Map<Product>(model);
                this.products.Add(productDb);
                this.products.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int productId)
        {
            var viewModel = this.products.All().To<ProductViewModel>().FirstOrDefault(p => p.Id == productId);
            ViewData["categories"] = this.categories.All().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            ViewData["subCategories"] = this.subCategories.All().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            ViewData["brands"] = this.brands.All().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            ViewData["sports"] = this.sports.All().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var productDb = this.Mapper.Map<Product>(model);
                this.products.Update(productDb);
                this.products.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int productId, string url)
        {
            this.products.Delete(productId);
            this.products.SaveChanges();

            return Redirect(url);
        }
    }
}