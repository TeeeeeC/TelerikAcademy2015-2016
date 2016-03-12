namespace BestSportsStore.Web.Controllers
{
    using Microsoft.AspNet.Identity;
    using Models.Comment;
    using Services.Contracts;
    using System.Web.Mvc;

    [Authorize]
    public class CommentsController : BaseController
    {
        public CommentsController(IProductsService productsService)
            : base(productsService)
        {
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateComment(CommentViewModel model, string url)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = this.HttpContext.User.Identity.GetUserId();
            this.ProductsService.AddComment(model.ProductId, userId, model.Content);

            return Redirect(url);
        }

        public ActionResult CreateComment(int productId)
        {
            return View(new CommentViewModel { ProductId = productId });
        }
    }
}