namespace BestSportsStore.Web.Controllers
{
    using Infrastructure.Mapping;

    using Models.Product;

    using Services.Contracts;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class BrandsController : BaseController
    {
        public BrandsController(IProductsService productsService)
            : base(productsService)
        {
        }

        public ActionResult Index(string brand, int page = 1, string query = null, string sortBy = SortByDefault, string sortOrder = SortOrderDefault)
        {
            brand = brand == "All" ? null : brand;
            var pagesCount = this.ProductsService.GetAllByBrand(brand, query).Count();
            var products = this.ProductsService
                 .GetAllByBrand(brand, query)
                 .To<ProductViewModel>();

            var viewModel = new PaginationViewModel()
            {
                CurrentPage = page,
                Products = this.Sort(products, sortBy, sortOrder).Skip((page - 1) * PageSize).Take(PageSize).ToList(),
                Brand = brand == null ? "All" : brand,
                Query = query,
                SortBy = sortBy,
                SortOrder = sortOrder,
                PagesCount = (int)Math.Ceiling(pagesCount / (decimal)PageSize)
            };

            return PartialView(PartialViewProducts, viewModel);
        }
    }
}