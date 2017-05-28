namespace BestSportsStore.Web.Controllers
{
    using AutoMapper;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Models.Product;
    using Services.Contracts;
    using System.Linq;
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        protected const string PartialViewProducts = "_ProductsPartial";
        protected const int PageSize = 3;
        protected const string Underscore = "_";
        protected const string SortByDefault = "Likes";
        protected const string SortOrderDefault = "Desc";

        private readonly IProductsService productsService;

        public BaseController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }

        public IProductsService ProductsService
        {
            get
            {
                return this.productsService;
            }
        }

        public string CurrentUserId
        {
            get
            {
                return this.HttpContext.User.Identity.GetUserId();
            }
        }

        protected IQueryable<ProductViewModel> Sort(IQueryable<ProductViewModel> products, string sortBy, string sortOrder)
        {
            if (sortBy == SortByDefault)
            {
                if (sortOrder == SortOrderDefault)
                    return products.OrderByDescending(p => p.Likes.Count);
                else
                    return products.OrderBy(p => p.Likes.Count);
            }

            if (sortBy == "Price")
            {
                if (sortOrder == SortOrderDefault)
                    return products.OrderByDescending(p => p.Price);
            }

            return products.OrderBy(p => p.Price);
        }
    }
}