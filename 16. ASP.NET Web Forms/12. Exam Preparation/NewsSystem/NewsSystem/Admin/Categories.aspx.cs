using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        private NewsSystemDbContext context = new NewsSystemDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Category> ListViewCategories_GetData()
        {
            return this.context.Categories.OrderBy(c => c.Name);
        }

        public void ListViewCategories_UpdateItem(int id)
        {
            Category item = this.context.Categories.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                try
                {
                    this.context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }

        public void ListViewCategories_DeleteItem(int id)
        {
            Category item = this.context.Categories.Find(id);
            this.context.Categories.Remove(item);
            this.context.SaveChanges();
        }

        public void ListViewCategories_InsertItem()
        {
            var item = new Category();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                try
                {
                    this.context.Categories.Add(item);
                    this.context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    this.LabelValidation.Text = string.Format("Category {0} already exists", item.Name);
                }
            }
        }
    }
}