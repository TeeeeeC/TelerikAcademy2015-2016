using System.Linq;
using System.Web.Mvc;

namespace NewsSystem.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var sortedNews = this.News.OrderByDescending(n => n.Rating).Take(5);
            return View(sortedNews);
        }
    }
}