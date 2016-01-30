using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Users
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.IsPostBack)
            {
                if (this.RadioButtonGender.SelectedItem != null)
                {
                    var male = this.RadioButtonGender.SelectedItem.Text;
                    if (male == "Male")
                    {
                        this.CheckBoxCars.Visible = true;
                        this.DropDownListCoffee.Visible = false;
                    }
                    else
                    {
                        this.CheckBoxCars.Visible = false;
                        this.DropDownListCoffee.Visible = true;
                    }
                }
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                this.LabelMessage.Text = "The page is valid!";
                this.LabelMessage.Visible = Page.IsValid;
            }
        }

        protected void ButtonLogonInfo_Click(object sender, EventArgs e)
        {
            this.Page.Validate("ValidationGroupLogon");
            if (this.Page.IsValid)
            {
                this.LabelIsValid.Text = "Logon form is valid.";
            }
        }

        protected void ButtonPersonalInfo_Click(object sender, EventArgs e)
        {
            this.Page.Validate("ValidationGroupPersonal");
            if (this.Page.IsValid)
            {
                this.LabelIsValid.Text = "Personal form is valid.";
            }
        }

        protected void ButtonAddressInfo_Click(object sender, EventArgs e)
        {
            this.Page.Validate("ValidationGroupAddress");
            if (this.Page.IsValid)
            {
                this.LabelIsValid.Text = "Address form is valid.";
            }
        }

        protected void CheckBoxRequired_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = CheckBoxAccept.Checked;
        }
    }
}