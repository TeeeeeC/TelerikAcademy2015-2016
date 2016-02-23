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
            if (ModelState.IsValid)
            {
                var userId = this.HttpContext.User.Identity.GetUserId();
                this.ProductsService.AddComment(model.ProductId, userId, model.Content);
            }
            else
            {
                ModelState.AddModelError("Content", "Content is required!");
            }

            return Redirect(url);
        }

        public ActionResult Index(int productId)
        {
            return PartialView("_CommentForm", new CommentViewModel { ProductId = productId });
        }
    }
}