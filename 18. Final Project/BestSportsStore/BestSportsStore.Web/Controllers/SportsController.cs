namespace BestSportsStore.Web.Controllers
{
    using Infrastructure.Mapping;

    using Models.Product;

    using Services.Contracts;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class SportsController : BaseController
    {
        public SportsController(IProductsService productsService)
            : base(productsService)
        {
        }

        public ActionResult Index(string sport, int page = 1, string query = null, string sortBy = SortByDefault, string sortOrder = SortOrderDefault)
        {
            sport = sport == "All" ? null : sport;
            var pagesCount = this.ProductsService.GetAllBySport(sport, query).Count();
            var products = this.ProductsService
                 .GetAllBySport(sport, query)
                 .To<ProductViewModel>();

            var viewModel = new PaginationViewModel()
            {
                CurrentPage = page,
                Products = this.Sort(products, sortBy, sortOrder).Skip((page - 1) * PageSize).Take(PageSize).ToList(),
                Sport = sport == null ? "All" : sport,
                Query = query,
                SortBy = sortBy,
                SortOrder = sortOrder,
                PagesCount = (int)Math.Ceiling(pagesCount / (decimal)PageSize)
            };

            return PartialView(PartialViewProducts, viewModel);
        }
    }
}