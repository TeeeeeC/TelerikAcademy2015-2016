using System;
using System.Linq;
using System.Threading;

namespace _1.Employees
{
    public partial class Index : System.Web.UI.Page
    {
        private NorthwindEntities db = new NorthwindEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewEmployees_Changed(object sender, EventArgs e)
        {
            Thread.Sleep(4000);
            var employeeId = int.Parse(this.GridViewEmployees.SelectedDataKey.Value.ToString());
            var orders = db.Orders.Where(o => o.EmployeeID == employeeId).ToList();

            this.GridViewOrders.DataSource = orders;
            this.GridViewOrders.DataBind();
            this.GridViewOrders.Visible = true;
        }
    }
}