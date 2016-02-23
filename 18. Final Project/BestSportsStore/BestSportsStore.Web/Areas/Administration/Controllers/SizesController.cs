namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Web.Models.Product;
    using System.Linq;
    using System.Web.Mvc;

    public class SizesController : BaseAdminController
    {
        private IRepository<Size> sizes;

        public SizesController(IRepository<Size> sizes)
        {
            this.sizes = sizes;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var sizes = this.sizes
               .All().To<SizeViewModel>();

            return Json(sizes.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update([DataSourceRequest] DataSourceRequest request, SizeViewModel size)
        {
            if (ModelState.IsValid)
            {
                var sizeEntry = this.sizes.All().FirstOrDefault(s => s.Id == size.Id);
                sizeEntry.Value = size.Value;
                this.sizes.Update(sizeEntry);
                this.sizes.SaveChanges();
            }

            return Json(new[] { size }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Create([DataSourceRequest] DataSourceRequest request, SizeViewModel size)
        {
            if (ModelState.IsValid)
            {
                var sizeToAdd = new Size
                {
                    Value = size.Value
                };

                this.sizes.Add(sizeToAdd);

                this.sizes.SaveChanges();
            }

            return Json(new[] { size }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Destroy([DataSourceRequest] DataSourceRequest request, SizeViewModel size)
        {
            var sizeEntry = this.sizes.All().FirstOrDefault(s => s.Id == size.Id);
            this.sizes.Delete(sizeEntry);
            this.sizes.SaveChanges();

            return Json(new[] { size }.ToDataSourceResult(request, ModelState));
        }
    }
}