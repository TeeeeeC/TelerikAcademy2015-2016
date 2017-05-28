using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Northwind
{
    public partial class Employees : System.Web.UI.Page
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        protected void Page_Init(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            employees = db.Employees.Select(emp => new EmployeeModel
            {
                Id = emp.EmployeeID,
                FirstName = emp.FirstName,
                LastName = emp.LastName
            })
            .ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridViewEmployees.DataSource = employees;
            this.GridViewEmployees.DataBind();
        }
    }
}