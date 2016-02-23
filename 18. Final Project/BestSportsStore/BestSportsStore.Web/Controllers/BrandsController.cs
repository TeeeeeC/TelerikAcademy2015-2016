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

        public ActionResult Index(string brand, int page = 1, string query = null)
        {
            brand = brand == "All" ? null : brand;
            var pagesCount = this.ProductsService.GetAllByBrand(brand, query).Count();
            var products = this.ProductsService
                 .GetAllByBrand(brand, query)
                 .To<ProductViewModel>()
                 .OrderBy(p => p.Title)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize)
                 .ToList();

            var viewModel = new PaginationViewModel()
            {
                CurrentPage = page,
                Products = products,
                Brand = brand == null ? "All" : brand,
                Query = query,
                PagesCount = (int)Math.Ceiling(pagesCount / (decimal)PageSize)
            };

            return PartialView(PartialViewProducts, viewModel);
        }
    }
}