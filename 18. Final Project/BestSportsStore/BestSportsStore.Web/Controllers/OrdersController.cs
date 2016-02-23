namespace BestSportsStore.Web.Controllers
{
    using Microsoft.AspNet.Identity;
    using Infrastructure.Mapping;
    using System.Linq;
    using System.Web.Mvc;
    using Services.Contracts;
    using Models.Orders;

    [Authorize]
    public class OrdersController : BaseController
    {
        private IOrdersService ordersService;

        public OrdersController(IProductsService productsService, IOrdersService ordersService)
            : base(productsService)
        {
            this.ordersService = ordersService;
        }

        public ActionResult Index()
        {
            var userId = this.HttpContext.User.Identity.GetUserId();
            var viewModel = this.ordersService.GetByUserId(userId).To<OrderViewModel>().ToList(); 

            return View(viewModel);
        }
    }
}