namespace BestSportsStore.Web.Controllers
{
    using Infrastructure.Mapping;
    using Models.Menu;
    using Models.Menu.Brand;
    using Models.Menu.Category;
    using Models.Product;
    using Models.Sport;
    using Services.Contracts;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        public ActionResult Index()
        {
            var viewModel = this.homeService
                .GetTopProducts(10)
                .To<ProductViewModel>()
                .ToList();

            return View(viewModel);
        }

        public ActionResult Menu()
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

            var viewModel = new MenuViewModel()
            {
                Categories = categories,
                Sports = sports,
                Brands = brands
            };

            return PartialView("_NavBar", viewModel);
        }
    }
}