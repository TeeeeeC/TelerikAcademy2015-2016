﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lifecycle
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.Response.Write("Page:PreInit" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            this.Response.Write("Page:Init" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Write("Page:Load" + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Response.Write("Page:PreRender" + "<br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // Response is unavailable at page unload
            // Response.Write("Page:Unload" + "<br/>");
        }
    }
}