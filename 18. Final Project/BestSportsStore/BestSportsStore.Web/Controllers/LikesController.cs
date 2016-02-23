namespace BestSportsStore.Web.Controllers
{
    using Data.Models;
    using Microsoft.AspNet.Identity;
    using Services.Contracts;
    using System.Linq;
    using System.Web.Mvc;

    [Authorize]
    public class LikesController : BaseController
    {
        public LikesController(IProductsService productsService)
            : base(productsService)
        {
        }

        public ActionResult Like(int productId, string url)
        {
            var userId = this.HttpContext.User.Identity.GetUserId();
            this.ProductsService.AddLike(productId, userId);

            return Redirect(url);
        }
    }
}