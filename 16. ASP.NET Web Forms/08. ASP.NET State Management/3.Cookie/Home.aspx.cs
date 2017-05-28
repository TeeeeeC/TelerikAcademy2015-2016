using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3.Cookie
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserName"];
            if (cookie != null)
            {
                string text = "Cookie was sent by the Web browser.";
                Response.Write(text);
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}