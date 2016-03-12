namespace BestSportsStore.Web.Controllers
{
    using Infrastructure.Mapping;
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

        public ActionResult Index(string category, string subCategory, string query = null, int page = 1, string sortBy = SortByDefault, string sortOrder = SortOrderDefault)
        {
            query = query == null ? string.Empty : query;
            var pagesCount = this.ProductsService.GetAllByCategory(category, subCategory, query).Count();
            var products = this.ProductsService
                 .GetAllByCategory(category, subCategory, query)
                 .To<ProductViewModel>();
            
            var viewModel = new PaginationViewModel()
            {
                CurrentPage = page,
                Products = this.Sort(products, sortBy, sortOrder).Skip((page - 1) * PageSize).Take(PageSize).ToList(),
                Category = category,
                SubCategory = subCategory,
                Query = query,
                SortBy = sortBy,
                SortOrder = sortOrder,
                PagesCount = (int)Math.Ceiling(pagesCount / (decimal)PageSize)
            };

            return PartialView(PartialViewProducts, viewModel);
        }

        public ActionResult Details(int id)
        {
            var viewModel = this.Mapper.Map<ProductViewModel>(this.ProductsService.GetById(id));
            viewModel.Comments = viewModel.Comments.OrderByDescending(c => c.CreatedOn).ToList();
            return View(viewModel);
        }
    }
}