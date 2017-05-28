namespace NewsSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    public class DetailsController : BaseController
    {
        public ActionResult ById(int id)
        {
            var itemNew = this.News.FirstOrDefault(n => n.Id == id);
            return View(itemNew);
        }
    }
}