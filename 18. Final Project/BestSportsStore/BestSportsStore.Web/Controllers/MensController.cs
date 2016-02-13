namespace BestSportsStore.Web.Controllers
{
    using Infrastructure.Mapping;

    using Models.Product;

    using Services.Contracts;

    using System.Linq;
    using System.Web.Mvc;

    public class MensController : Controller
    {
        private const string CategoryName = "Mens";
        private const string SubCategoryFootWear = "FootWear";
        private const string SubCategoryClothing = "Clothing";

        private readonly IProductsService mensService;

        public MensController(IProductsService mensService)
        {
            this.mensService = mensService;
        }

        // GET: Category Mens
        public ActionResult Index()
        {
            var viewModel = this.mensService
              .GetAllByCategory(CategoryName)
              .To<ProductViewModel>()
              .ToList();

            return PartialView("_SubCategory", viewModel);
        }

        // GET: Category Mens FootWear
        public ActionResult FootWear()
        {
            var viewModel = this.mensService
              .GetAllByCategory(CategoryName, SubCategoryFootWear)
              .To<ProductViewModel>()
              .ToList();

            return PartialView("_SubCategory", viewModel);
        }

        // GET: Category Mens Clothing
        public ActionResult Clothing()
        {
            var viewModel = this.mensService
              .GetAllByCategory(CategoryName, SubCategoryClothing)
              .To<ProductViewModel>()
              .ToList();

            return PartialView("_SubCategory", viewModel);
        }
    }
}