namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
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
            var viewModel = this.sports.All().To<SportViewModel>().ToList();

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SportViewModel model)
        {
            if (ModelState.IsValid)
            {
                var sportDb = this.Mapper.Map<Sport>(model);
                this.sports.Add(sportDb);
                this.sports.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int sportId)
        {
            var viewModel = this.sports.All().To<SportViewModel>().FirstOrDefault(s => s.Id == sportId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(SportViewModel model)
        {
            if (ModelState.IsValid)
            {
                var sportDb = this.Mapper.Map<Sport>(model);
                this.sports.Update(sportDb);
                this.sports.SaveChanges();

                this.HttpContext.Cache.Remove("menu");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int sportId, string url)
        {
            this.sports.Delete(sportId);
            this.sports.SaveChanges();

            this.HttpContext.Cache.Remove("menu");

            return Redirect(url);
        }
    }
}