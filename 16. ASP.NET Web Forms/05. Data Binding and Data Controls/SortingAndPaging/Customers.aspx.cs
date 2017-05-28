using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SortingAndPaging
{
    public partial class Employees : System.Web.UI.Page
    {
        private List<CustomerModel> customers = new List<CustomerModel>();
        private string sortByParam = "Name";

        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            customers = db.Customers.Select(c => new CustomerModel
            {
                Name = c.CompanyName,
                ContactName = c.ContactName,
                ContactTitle = c.ContactTitle,
                Address = c.Address,
                City = c.City,
                Country = c.Country,
                Phone = c.Phone,
                Fax = c.Fax
            })
            .ToList();

            this.GridViewCustomers.DataSource = customers;
            this.DataBind();
        }

        protected void GridViewCustomers_PageIndexChanging(object sender,
            System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            this.GridViewCustomers.PageIndex = e.NewPageIndex;
            this.GridViewCustomers.DataSource = this.Sort(this.sortByParam); 
            this.GridViewCustomers.DataBind();
        }

        protected void GridViewCustomers_Sorting(object sender, GridViewSortEventArgs e)
        {
            this.sortByParam = e.SortExpression;
            this.GridViewCustomers.DataSource = this.Sort(e.SortExpression);
            this.DataBind();
        }

        private IList<CustomerModel> Sort(string sortBy)
        {
            if (sortBy == "Name")
            {
               return this.customers.OrderBy(c => c.Name).ToList();
            }
            else if (sortBy == "City")
            {
                return this.customers.OrderBy(c => c.City).ToList();
            }

            return this.customers.OrderBy(c => c.Country).ToList();
        }
        
        
        [WebMethod]
        public static CustomerModel Get(string name)
        {
            var db = new NorthwindEntities();
            var customer = db.Customers.Where(c => c.CompanyName == name).Select(c => new CustomerModel
            {
                Name = c.CompanyName,
                ContactName = c.ContactName,
                ContactTitle = c.ContactTitle,
                Address = c.Address,
                City = c.City,
                Country = c.Country,
                Phone = c.Phone,
                Fax = c.Fax
            })
            .FirstOrDefault();

            return customer;
        }
    }
}