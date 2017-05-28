namespace BestSportsStore.Web.Controllers
{
    using Infrastructure.Mapping;
    using Models.Menu;
    using Models.Menu.Brand;
    using Models.Menu.Category;
    using Models.Product;
    using Models.Sport;
    using Services.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        public ActionResult Index()
        {
            List<ProductViewModel> viewModel = this.homeService
                    .GetTopProducts(10)
                    .To<ProductViewModel>()
                    .ToList();

            return View(viewModel);
        }

        public ActionResult Menu()
        {
            MenuViewModel viewModel;
            if (this.HttpContext.Cache["menu"] != null)
            {
                viewModel = (MenuViewModel)this.HttpContext.Cache["menu"];
            }
            else
            {
                var categories = this.homeService
                .GetCategories()
                .To<CategoryViewModel>()
                .ToList();

                var sports = this.homeService
                    .GetSports()
                    .To<SportViewModel>()
                    .ToList();

                var brands = this.homeService
                    .GetBrands()
                    .To<BrandViewModel>()
                    .ToList();

                viewModel = new MenuViewModel()
                {
                    Categories = categories,
                    Sports = sports,
                    Brands = brands
                };

                this.HttpContext.Cache["menu"] = viewModel;
            }

            return PartialView("_NavigationPartial", viewModel);
        }
    }
}