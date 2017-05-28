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
            var viewModel = this.ordersService.GetByUserId(this.CurrentUserId).To<OrderViewModel>().ToList(); 

            return View(viewModel);
        }

        public ActionResult Details()
        {
            var orderId = int.Parse(Request.Url.Segments[Request.Url.Segments.Count() - 1]);
            var viewModel = this.ordersService.GetByUserId(this.CurrentUserId).To<OrderViewModel>().FirstOrDefault(o => o.Id == orderId);

            return View(viewModel);
        }
    }
}