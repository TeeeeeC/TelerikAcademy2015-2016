namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
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
            var viewModel = this.brands.All().To<BrandViewModel>().ToList();

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BrandViewModel model)
        {
            if (ModelState.IsValid)
            {
                var brandDb = this.Mapper.Map<Brand>(model);
                this.brands.Add(brandDb);
                this.brands.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int brandId)
        {
            var viewModel = this.brands.All().To<BrandViewModel>().FirstOrDefault(b => b.Id == brandId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(BrandViewModel model)
        {
            if (ModelState.IsValid)
            {
                var brandDb = this.Mapper.Map<Brand>(model);
                this.brands.Update(brandDb);
                this.brands.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int brandId, string url)
        {
            this.brands.Delete(brandId);
            this.brands.SaveChanges();

            this.HttpContext.Cache.Remove("menu");

            return Redirect(url);
        }
    }
}