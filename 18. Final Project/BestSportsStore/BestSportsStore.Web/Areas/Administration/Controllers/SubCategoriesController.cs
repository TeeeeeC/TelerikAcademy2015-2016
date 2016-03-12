namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Models;
    using System.Linq;
    using System.Web.Mvc;
    using Web.Models.Menu.Category;

    public class SubCategoriesController : BaseAdminController
    {
        private IRepository<Category> categories;
        private IRepository<SubCategory> subCategories;

        public SubCategoriesController(IRepository<Category> categories, IRepository<SubCategory> subCategories)
        {
            this.categories = categories;
            this.subCategories = subCategories;
        }

        public ActionResult Index()
        {
            var viewModel = this.subCategories.All().To<SubCategoryViewModel>().ToList();

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var categories = this.categories.All().Select(s => s.Name).ToList();

            return View(new SubCategoryViewModel { CategoryNames = categories });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var subCategoryDb = this.Mapper.Map<SubCategory>(model);
                this.subCategories.Add(subCategoryDb);
                this.subCategories.SaveChanges();

                if (model.CategoryNames != null && model.CategoryNames.Count > 0)
                {
                    var categories = this.categories.All().ToList();
                    foreach (var category in categories)
                    {
                        if (model.CategoryNames.Contains(category.Name))
                        {
                            subCategoryDb.Categories.Add(category);
                        }
                    }
                }

                this.categories.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int subCategoryId)
        {
            var viewModel = this.subCategories.All().To<SubCategoryViewModel>().FirstOrDefault(s => s.Id == subCategoryId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(SubCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var subCategoryDb = this.Mapper.Map<SubCategory>(model);
                this.subCategories.Update(subCategoryDb);
                this.subCategories.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int subCategoryId, string url)
        {
            this.subCategories.Delete(subCategoryId);
            this.subCategories.SaveChanges();

            this.HttpContext.Cache.Remove("menu");

            return Redirect(url);
        }
    }
}