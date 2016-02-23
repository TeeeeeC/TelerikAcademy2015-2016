namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using System.Linq;
    using System.Web.Mvc;
    using Web.Models.Menu.Brand;

    public class BrandsController : BaseAdminController
    {
        private IRepository<Brand> brands;

        public BrandsController(IRepository<Brand> brands)
        {
            this.brands = brands;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var brands = this.brands
               .All().To<BrandViewModel>();

            return Json(brands.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update([DataSourceRequest] DataSourceRequest request, BrandViewModel brand)
        {
            if (ModelState.IsValid)
            {
                var brandEntry = this.brands.All().FirstOrDefault(b => b.Id == brand.Id);
                brandEntry.Name = brand.Name;
                brandEntry.ImageUrl = brand.ImageUrl;
                this.brands.Update(brandEntry);
                this.brands.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return Json(new[] { brand }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Create([DataSourceRequest] DataSourceRequest request, BrandViewModel brand)
        {
            if (ModelState.IsValid)
            {

                var brandToAdd = new Brand
                {
                    Name = brand.Name,
                    ImageUrl = brand.Name
                };

                this.brands.Add(brandToAdd);
                this.brands.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return Json(new[] { brand }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Destroy([DataSourceRequest] DataSourceRequest request, BrandViewModel brand)
        {
            var brandEntry = this.brands.All().FirstOrDefault(b => b.Id == brand.Id);
            this.brands.Delete(brandEntry);
            this.brands.SaveChanges();

            this.HttpContext.Cache.Remove("menu");

            return Json(new[] { brand }.ToDataSourceResult(request, ModelState));
        }
    }
}