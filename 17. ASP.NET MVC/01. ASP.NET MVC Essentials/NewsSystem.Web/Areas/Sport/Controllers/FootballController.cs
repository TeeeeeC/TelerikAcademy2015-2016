using NewsSystem.Web.Controllers;
using System.Linq;
using System.Web.Mvc;

namespace NewsSystem.Web.Areas.Sport.Controllers
{
    public class FootballController : BaseController
    {
        public ActionResult Index()
        {
            var news = this.News.Where(n => n.Category == "football").ToList();
            return View(news);
        }
    }
}