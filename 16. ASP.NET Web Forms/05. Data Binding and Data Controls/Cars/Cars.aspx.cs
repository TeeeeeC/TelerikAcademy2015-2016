using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cars
{
    public partial class Cars : System.Web.UI.Page
    {
        private List<Producer> producers = new List<Producer>()
        {
            new Producer() { Name = "Audi", Models = new List<string>() { "50", "60", "80", "A1", "A2"} },
            new Producer() { Name = "Lamborghini", Models = new List<string>() { "Aventador", "Gallardo", "Veneno"} },
            new Producer() { Name = "Honda", Models = new List<string>() { "City", "Civic", "Fit", "Jass", "Logo"} },
        };

        private List<Extra> extras = new List<Extra>()
        {
            new Extra() { Name = "DVD"},
            new Extra() { Name = "AirConditioning"},
            new Extra() { Name = "GPS"},
            new Extra() { Name = "Bluetooth"},
            new Extra() { Name = "Alarm"}
        };

        private string[] engineTypes = new string[]
        {
            "petrol",
            "diesel",
            "electrical",
            "hybrid"
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["extras"] = this.extras.Select(ex => ex.Name).ToArray();
                var extras = ((string[])ViewState["extras"]).Select(x => new ListItem(x)).ToArray();
                this.CheckBoxListExtra.Items.AddRange(extras);

                ViewState["engineTypes"] = this.engineTypes;
                var types = ((string[])ViewState["engineTypes"]).Select(x => new ListItem(x)).ToArray();
                this.RadioButtonListEngine.Items.AddRange(types);
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["producers"] = this.producers.Select(p => p.Name).ToArray();

            if (!IsPostBack)
            {
                var producers = ((string[])ViewState["producers"]).Select(x => new ListItem(x)).ToArray();
                this.DropDownListProducer.Items.AddRange(producers);
                this.DropDownListProducer.DataBind();
            }
        }

        protected void SearchButton_Command(object sender, CommandEventArgs e)
        {
            var text = new StringBuilder();

            text.Append("Searching... <br/>");
            text.Append("Producer: " + this.DropDownListProducer.SelectedItem.Text + "<br/>");
            text.Append("Model: " + this.DropDownListModel.SelectedItem.Text + "<br/>");

            var extras = this.CheckBoxListExtra.Items;
            var selectedExtras = new List<string>();
            foreach (ListItem extra in extras)
            {
                if(extra.Selected)
                {
                    selectedExtras.Add(extra.Text);
                }
            }

            text.Append("Extras: " + string.Join(", ", selectedExtras) + "<br/>");
            text.Append("Engine type: " + this.RadioButtonListEngine.SelectedItem.Text + "<br/>");

            this.searchedParams.Text = text.ToString();
        }

        protected void DropDownListProducer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList listView = sender as DropDownList;
            if (listView == null)
            {
                return;
            }

            ViewState["models"] = GetModelsByProducerName(listView.SelectedValue).ToArray();
            var models = ((string[])ViewState["models"]).Select(x => new ListItem(x)).ToArray();

            if (models.Length > 0)
            {
                this.DropDownListModel.DataSource = models;
            }
            else
            {
                this.DropDownListModel.DataSource = new ListItem[] { new ListItem("all") };
            }
            this.DropDownListModel.DataBind();
        }

        protected void DropDownListModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private IEnumerable<string> GetModelsByProducerName(string selectedProducerName)
        {
            return this.producers
               .Where(x => x.Name == selectedProducerName)
               .SelectMany(x => x.Models)
               .ToArray();
        }
    }
}