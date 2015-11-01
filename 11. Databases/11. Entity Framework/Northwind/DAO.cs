namespace Northwind
{
    using System;
    using System.Linq;

    internal class DAO
    {
        public static void InsertCustomer(Customer customer)
        {
            using(var db = new NorthwindEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }

            Console.WriteLine("New customer added!");
        }

        public static void UpdateCustomer(string customerID, Customer newCustomer)
        {
            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers
                                 .Where(cus => cus.CustomerID == customerID)
                                 .FirstOrDefault();

                customer.Address = newCustomer.Address ?? customer.Address;
                customer.City = newCustomer.City ?? customer.City;
                customer.CompanyName = newCustomer.CompanyName ?? customer.CompanyName;
                customer.ContactName = newCustomer.ContactName ?? customer.ContactName;
                customer.ContactTitle = newCustomer.ContactTitle ?? customer.ContactTitle;
                customer.Country = newCustomer.Country ?? customer.Country;
                customer.CustomerID = newCustomer.CustomerID ?? customer.CustomerID;
                customer.Fax = newCustomer.Fax ?? customer.Fax;
                customer.Phone = newCustomer.Phone ?? customer.Phone;
                customer.PostalCode = newCustomer.PostalCode ?? customer.PostalCode;
                customer.Region = newCustomer.Region ?? customer.Region;

                db.SaveChanges();
            }

            Console.WriteLine("Customer updated!");
        }

        public static void DeleteCustomer(string customerID)
        {
            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers
                                 .Where(cus => cus.CustomerID == customerID)
                                 .FirstOrDefault();

                db.Customers.Remove(customer);
                db.SaveChanges();
            }

            Console.WriteLine("The customer is removed!");
        }
    }
}
