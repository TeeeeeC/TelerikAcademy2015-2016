using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using NewsSystem.Models;

namespace NewsSystem
{
    public partial class Home : System.Web.UI.Page
    {
        private NewsSystemDbContext context = new NewsSystemDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IEnumerable<Article> RepeaterArticles_GetItems()
        {
            var topArticles = this.context
                .Articles
                .OrderByDescending(a => a.Likes.Count)
                .Take(3)
                .ToList();

            return topArticles;
        }

        public IEnumerable<Category> ListViewCategories_GetData()
        {
            return this.context.Categories.ToList();
        }
    }
}