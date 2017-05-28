using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.World
{
    public partial class World : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Add_Continent_Click(object sender, EventArgs e)
        {
            if (this.Continent.Text.Length > 3)
            {
                var db = new WorldEntities();
                var country = new Continent() { Name = this.Continent.Text };
                db.Continents.Add(country);
                db.SaveChanges();
                Response.Redirect("~/World.aspx");
            }
            else
            {
                Response.Write("The continent length must be greater than 3 symbols!");
            }
        }

        protected void Delete_Continent_Click(object sender, EventArgs e)
        {
            if (this.ListBoxContinents.SelectedItem != null)
            {
                var db = new WorldEntities();
                var name = this.ListBoxContinents.SelectedItem.Text;
                var continent = db.Continents.Where(c => c.Name == name).FirstOrDefault();
                db.Continents.Remove(continent);
                db.SaveChanges();
                Response.Redirect("~/World.aspx");
            }
        }

        protected void Update_Continent_Click(object sender, EventArgs e)
        {
            if (this.ListBoxContinents.SelectedItem != null)
            {
                var db = new WorldEntities();
                var name = this.ListBoxContinents.SelectedItem.Text;
                var continent = db.Continents.Where(c => c.Name == name).FirstOrDefault();
                continent.Name = this.Update.Text.Trim();
                db.SaveChanges();
                Response.Redirect("~/World.aspx");
            }
        }

        protected void ListBoxContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Update.Text = this.ListBoxContinents.SelectedItem.Text;
        }
    }
}