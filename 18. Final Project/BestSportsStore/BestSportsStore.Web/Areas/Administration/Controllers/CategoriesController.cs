namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Web.Models.Menu.Category;
    using System.Linq;
    using System.Web.Mvc;

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
            return View();
        }

        public JsonResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var categories = this.categories
               .All().To<CategoryViewModel>();

            return Json(categories.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update([DataSourceRequest] DataSourceRequest request, CategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                var categoryEntry = this.categories.All().FirstOrDefault(c => c.Id == category.Id);
                categoryEntry.Name = category.Name;
                this.categories.Update(categoryEntry);
                this.categories.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Create([DataSourceRequest] DataSourceRequest request, CategoryViewModel category)
        {
            if (ModelState.IsValid)
            {

                var categorytoadd = new Category
                {
                    Name = category.Name
                };

                this.categories.Add(categorytoadd);

                this.categories.SaveChanges();

                var subCategories = this.subCategories.All().ToList();
                for (int i = 0; i < subCategories.Count; i++)
                {
                    subCategories[i].Categories.Add(categorytoadd);
                }

                this.subCategories.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Destroy([DataSourceRequest] DataSourceRequest request, CategoryViewModel category)
        {
            var categoryEntry = this.categories.All().FirstOrDefault(c => c.Id == category.Id);
            this.categories.Delete(categoryEntry);
            this.categories.SaveChanges();

            this.HttpContext.Cache.Remove("menu");

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        // SubCategories footwear, clothing, accessories

        public ActionResult SubCategories()
        {
            return View();
        }

        public JsonResult ReadSubCategories([DataSourceRequest] DataSourceRequest request)
        {
            var subCategories = this.subCategories
               .All().To<SubCategoryViewModel>();

            return Json(subCategories.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateSubCategories([DataSourceRequest] DataSourceRequest request, SubCategoryViewModel subCategory)
        {
            if (subCategory != null && ModelState.IsValid)
            {
                var subCategoryEntry = this.subCategories.All().FirstOrDefault(s => s.Id == subCategory.Id);
                subCategoryEntry.Name = subCategory.Name;
                this.subCategories.Update(subCategoryEntry);
                this.subCategories.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return Json(new[] { subCategory }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult CreateSubCategories([DataSourceRequest] DataSourceRequest request, SubCategoryViewModel subCategory)
        {
            if (subCategory != null && ModelState.IsValid)
            {
                var subCategoryToAdd = new SubCategory
                {
                    Name = subCategory.Name
                };

                this.subCategories.Add(subCategoryToAdd);

                this.subCategories.SaveChanges();

                var categories = this.categories.All().ToList();
                for (int i = 0; i < categories.Count; i++)
                {
                    categories[i].SubCategories.Add(subCategoryToAdd);
                }

                this.categories.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return Json(new[] { subCategory }.ToDataSourceResult(request, ModelState));
        }


        public JsonResult DestroySubCategories([DataSourceRequest] DataSourceRequest request, SubCategoryViewModel subCategory)
        {
            var subCategoryEntry = this.subCategories.All().FirstOrDefault(s => s.Id == subCategory.Id);
            this.subCategories.Delete(subCategoryEntry);
            this.subCategories.SaveChanges();

            this.HttpContext.Cache.Remove("menu");

            return Json(new[] { subCategory }.ToDataSourceResult(request, ModelState));
        }

    }
}