using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.SessionTasks
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
        }

        protected void buttonAddLoad_Click(object sender, EventArgs e)
        {
            var list = new List<string>((List<string>)Session["Text"]);
            list.Add(this.Text_Input.Text);
            Session["Text"] = list;
        }

        protected override void OnPreRender(EventArgs e)
        {
            if (Session["Text"] == null)
            {
                Session["Text"] = new List<string>();
            }

            ResultText.Text = string.Join(", ", (List<string>)Session["Text"]);
        }
    }
}