using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Northwind
{
    public partial class EmpDetails : System.Web.UI.Page
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        protected void Page_Init(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            employees = db.Employees.Select(emp => new EmployeeModel
            {
                Id = emp.EmployeeID,
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Title = emp.Title,
                TitleOfCourtesy = emp.TitleOfCourtesy,
                BirthDate = emp.BirthDate,
                HireDate = emp.HireDate,
                Address = emp.Address,
                City = emp.City,
                Country = emp.Country
            })
            .ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.Params["Id"]);
            foreach (var emp in employees)
            {
                if (emp.Id == id)
                {
                    var emps = new List<EmployeeModel>();
                    emps.Add(emp);
                    this.DetailsViewEmployee.DataSource = emps;
                    this.DetailsViewEmployee.DataBind();
                    break;
                }
            }
        }
    }
}