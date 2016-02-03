namespace NewsSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    public class UsersController : BaseController
    {
        public ActionResult All(string username)
        {
            if(username != "DefaultValue")
            {
                return View(this.Users.Where(u => u.Username == username).ToList());
            }

            return View(this.Users);
        }
    }
}