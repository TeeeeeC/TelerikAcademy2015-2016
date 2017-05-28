using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3.Students
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registration_Click(object sender, EventArgs e)
        {
            var firstName = new Label();
            firstName.Text = "FirstName: " + this.firstName.Text + "<br/>";
            this.MainForm.Controls.Add(firstName);

            var lastName = new Label();
            lastName.Text = "LastName: " + this.lastName.Text + "<br/>";
            this.MainForm.Controls.Add(lastName);

            var number = new Label();
            number.Text = "Faculty Number: " + this.fNumber.Text + "<br/>";
            this.MainForm.Controls.Add(number);

            var university = new Label();
            university.Text = "University: " + this.DropDownListUniversity.Text + "<br/>";
            this.MainForm.Controls.Add(university);

            var specialy = new Label();
            specialy.Text = "Specialy: " + this.DropDownListSpecialy.Text + "<br/>";
            this.MainForm.Controls.Add(specialy);

            var courses = new Label();
            var selectedItems = new List<string>();
            foreach (var index in this.ListBoxCourses.GetSelectedIndices())
            {
                selectedItems.Add(this.ListBoxCourses.Items[index].Text);
            }
            courses.Text = "Courses: " + string.Join(", ", selectedItems) + "<br/>";
            this.MainForm.Controls.Add(courses);
        }
    }
}