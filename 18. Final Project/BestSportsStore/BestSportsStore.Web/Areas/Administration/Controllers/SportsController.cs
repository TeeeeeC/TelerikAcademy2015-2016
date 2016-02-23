namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Web.Models.Sport;
    using System.Linq;
    using System.Web.Mvc;

    public class SportsController : BaseAdminController
    {
        private IRepository<Sport> sports;

        public SportsController(IRepository<Sport> sports)
        {
            this.sports = sports;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var sports = this.sports
               .All().To<SportViewModel>();

            return Json(sports.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update([DataSourceRequest] DataSourceRequest request, SportViewModel sport)
        {
            if (ModelState.IsValid)
            {
                var sportEntry = this.sports.All().FirstOrDefault(s => s.Id == sport.Id);
                sportEntry.Name = sport.Name;
                this.sports.Update(sportEntry);
                this.sports.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return Json(new[] { sport }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Create([DataSourceRequest] DataSourceRequest request, SportViewModel sport)
        {
            if (ModelState.IsValid)
            {
                var sportToAdd = new Sport
                {
                    Name = sport.Name,
                };

                this.sports.Add(sportToAdd);
                this.sports.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return Json(new[] { sport }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult Destroy([DataSourceRequest] DataSourceRequest request, SportViewModel sport)
        {
            var sportEntry = this.sports.All().FirstOrDefault(s => s.Id == sport.Id);
            this.sports.Delete(sportEntry);
            this.sports.SaveChanges();

            this.HttpContext.Cache.Remove("menu");

            return Json(new[] { sport }.ToDataSourceResult(request, ModelState));
        }
    }
}