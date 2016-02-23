namespace BestSportsStore.Web.Controllers
{
    using AutoMapper;
    using Infrastructure.Mapping;
    using Services.Contracts;
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        protected const string PartialViewProducts = "_ProductsPartial";
        protected const string PartialViewSearch = "_SearchPartial";
        protected const int PageSize = 3;
        protected const string Underscore = "_";

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
    }
}