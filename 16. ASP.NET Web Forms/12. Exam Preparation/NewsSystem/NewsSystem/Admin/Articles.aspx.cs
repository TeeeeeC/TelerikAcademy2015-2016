using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace NewsSystem.Admin
{
    public partial class Articles : System.Web.UI.Page
    {
        private NewsSystemDbContext context = new NewsSystemDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Article> ListViewArticles_GetData()
        {
            var result = this.context.Articles;

            var orderBy = ViewState["sortDirection"];
            // TODO: validate orderBy parameter
            //result.OrderBy(orderBy + " " + SortDirection)

            //result = orderBy != null ? null : result.OrderBy(x => x.Id);
            return result;
        }

        public void ListViewArticles_InsertItem()
        {
            var item = new Article();
            item.DateCreated = DateTime.Now;
            item.AuthorId = User.Identity.GetUserId();
       
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.context.Articles.Add(item);
                this.context.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_UpdateItem(int id)
        {
            Article item = this.context.Articles.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.context.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_DeleteItem(int id)
        {
            Article item = this.context.Articles.Find(id);
            this.context.Articles.Remove(item);
            this.context.SaveChanges();
        }


        public IQueryable<Category> DropDownListCategories_GetData()
        {
            return this.context.Categories.OrderBy(c => c.Name);
        }
    }
}