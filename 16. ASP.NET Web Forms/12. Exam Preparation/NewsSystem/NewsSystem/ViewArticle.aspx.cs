using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
    public partial class ViewArticle : System.Web.UI.Page
    {
        private NewsSystemDbContext context = new NewsSystemDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Article FormViewArticle_GetItem([QueryString]int? id)
        {
            if(id == null)
            {
                Response.Redirect("~/");
            }

            return this.context
                .Articles
                .FirstOrDefault(a => a.Id == id);
        }
    }
}