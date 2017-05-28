namespace BestSportsStore.Web.Areas.Administration.Controllers
{
    using Data.Models;
    using Data.Repositories;
    using Infrastructure.Mapping;
    using Models;
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Web.Models.Product;

    public class SizesController : BaseAdminController
    {
        private IRepository<Size> sizes;

        public SizesController(IRepository<Size> sizes)
        {
            this.sizes = sizes;
        }

        public ActionResult Index(int page = 1)
        {
            var pagesCount = this.sizes.All().Count();
            var viewModel = new SizeGridViewModel
            {
                CurrentPage = page,
                PagesCount = (int) Math.Ceiling(pagesCount / (decimal) PageSize),
                Sizes = this.sizes.All().To<SizeViewModel>().OrderBy(s => s.Value).Skip((page - 1) * PageSize).Take(PageSize).ToList()
            };

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SizeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var sizeDb = this.Mapper.Map<Size>(model);
                this.sizes.Add(sizeDb);
                this.sizes.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int sizeId)
        {
            var viewModel = this.sizes.All().To<SizeViewModel>().FirstOrDefault(s => s.Id == sizeId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(SizeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var sizeDb = this.Mapper.Map<Size>(model);
                this.sizes.Update(sizeDb);
                this.sizes.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int sizeId, string url)
        {
            this.sizes.Delete(sizeId);
            this.sizes.SaveChanges();

            return Redirect(url);
        }
    }
}