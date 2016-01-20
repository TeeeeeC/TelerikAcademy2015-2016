using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.Escaping
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            this.result.Text = Server.HtmlEncode(this.text.Text);
            this.resultLabel.Text = Server.HtmlEncode(this.text.Text);
        }
    }
}