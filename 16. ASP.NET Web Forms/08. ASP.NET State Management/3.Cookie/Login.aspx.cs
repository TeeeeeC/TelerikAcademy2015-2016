using System;
using System.Web;

namespace _3.Cookie
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Btn_click_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserName", "You are logged in!");
            cookie.Expires = DateTime.Now.AddMinutes(1);

            Response.Cookies.Add(cookie);
            Response.Redirect("~/Home.aspx");
        }
    }
}