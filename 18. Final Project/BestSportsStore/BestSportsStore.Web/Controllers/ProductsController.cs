namespace BestSportsStore.Web.Controllers
{
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Models.Product;

    using Services.Contracts;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class ProductsController : BaseController
    {
        public ProductsController(IProductsService productsService)
            : base(productsService)
        {
        }

        public ActionResult Index(string category, string subCategory, string query = null, int page = 1)
        {
            query = query == null ? string.Empty : query;
            var pagesCount = this.ProductsService.GetAllByCategory(category, subCategory, query).Count();
            var products = this.ProductsService
                 .GetAllByCategory(category, subCategory, query)
                 .To<ProductViewModel>()
                 .OrderBy(p => p.Title)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize)
                 .ToList();

            var viewModel = new PaginationViewModel()
            {
                CurrentPage = page,
                Products = products,
                Category = category,
                SubCategory = subCategory,
                Query = query,
                PagesCount = (int)Math.Ceiling(pagesCount / (decimal)PageSize)
            };

            return PartialView(PartialViewProducts, viewModel);
        }

        public ActionResult AutoCompleteData(string category, string subCategory, string brand, string sport)
        {
            var data = this.ProductsService
                .GetAllTitleAndContent()
                .ToList();

            var viewModel = new SearchViewModel
            {
                Data = data,
                Category = category,
                SubCategory = subCategory,
                Brand = brand,
                Sport = sport,
            };

            return PartialView(PartialViewSearch, viewModel);
        }

        public ActionResult Details(int id)
        {
            var viewModel = this.Mapper.Map<ProductViewModel>(this.ProductsService.GetById(id));
            viewModel.Comments = viewModel.Comments.OrderByDescending(c => c.CreatedOn).ToList();
            return View(viewModel);
        }
    }
}