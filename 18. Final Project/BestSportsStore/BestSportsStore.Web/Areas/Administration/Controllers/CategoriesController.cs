namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Models;
    using System.Linq;
    using System.Web.Mvc;
    using Web.Models.Menu.Category;

    public class CategoriesController : BaseAdminController
    {
        private IRepository<Category> categories;
        private IRepository<SubCategory> subCategories;

        public CategoriesController(IRepository<Category> categories, IRepository<SubCategory> subCategories)
        {
            this.categories = categories;
            this.subCategories = subCategories;
        }

        public ActionResult Index()
        {
            var viewModel = this.categories.All().To<CategoryViewModel>().ToList();

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var subCategories = this.subCategories.All().Select(s => s.Name).ToList();
            ViewData["subCategories"] = subCategories;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var categoryDb = this.Mapper.Map<Category>(model);
                this.categories.Add(categoryDb);
                this.categories.SaveChanges();

                if(model.SubCategoryNames != null && model.SubCategoryNames.Count > 0)
                {
                    var subCategories = this.subCategories.All().ToList();
                    foreach (var subCategory in subCategories)
                    {
                        if (model.SubCategoryNames.Contains(subCategory.Name))
                        {
                            categoryDb.SubCategories.Add(subCategory);
                        }
                    }
                }

                this.categories.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int categoryId)
        {
            var viewModel = this.categories.All().To<CategoryViewModel>().FirstOrDefault(c => c.Id == categoryId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var categoryDb = this.Mapper.Map<Category>(model);
                this.categories.Update(categoryDb);
                this.categories.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int categoryId, string url)
        {
            this.categories.Delete(categoryId);
            this.categories.SaveChanges();

            this.HttpContext.Cache.Remove("menu");

            return Redirect(url);
        }
    }
}