using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.BrowserInfo
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Write("Browser: " + this.Request.Browser.Type + "<br/>");
            this.Response.Write("IP Address: " + this.Request.ServerVariables["REMOTE_ADDR"]);
        }
    }
}