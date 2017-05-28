namespace _1.Random
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.result.Value = this.GetRandom(int.Parse(this.min.Value), int.Parse(this.max.Value));
        }

        protected void ButtonSubmitWeb_Click(object sender, EventArgs e)
        {
            this.resultWeb.Text = this.GetRandom(int.Parse(this.minWeb.Text), int.Parse(this.maxWeb.Text)); ;
        }

        private string GetRandom(int min, int max)
        {
            var random = new Random();
            if (min > max)
            {
                var storedValue = min;
                min = max;
                max = storedValue;
            }

            return (random.Next(min, max + 1)).ToString();
        }
    }
}