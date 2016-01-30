using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5.WebCounter
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonAddLoad_Click(object sender, EventArgs e)
        {
            Application.Lock();
            Application["Users"] = (int)Application["Users"] + 1;
            Application.UnLock();
            Response.Redirect("~/Counter.aspx");
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            Application.Lock();
            if (Application["Users"] == null)
            {
                Application["Users"] = 0;
            }
            Application.UnLock();
        }
    }
}