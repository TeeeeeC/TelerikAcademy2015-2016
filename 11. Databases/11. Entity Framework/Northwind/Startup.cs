namespace Northwind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.SqlServer.Management.Smo;
    using System.Data.Entity.Core;
    using System.Data.Entity.Core.Objects;

    internal class Startup
    {
        private static void Main()
        {
            // 2.
            var customer = new Customer
            {
               Address = "Perla 3",
               City = "Sofia",
               CompanyName = "PeshoEOOD",
               ContactName = "Pesho",
               ContactTitle = "Pesho",
               Country = "Bulgaria",
               CustomerID = "AAAAA",
               Fax = "222/ 222222",
               Phone = "089999999",
               PostalCode = "1367",
               Region = null,
            };

            DAO.InsertCustomer(customer);

            // The last one in database
            //DAO.DeleteCustomer("WOLZA"); 

            var newCust = new Customer();
            newCust.Address = "Pirotska 12";

            // It must update only Address in concrete CustomerID
            DAO.UpdateCustomer("AAAAA", newCust);
            Console.WriteLine();

            // 3.
            var customers = FindAllCustomersByOrdersIn1997AndShippedToCanada();
            foreach (var cust in customers)
            {
                Console.WriteLine(cust.ContactName);
            }
            Console.WriteLine();

            // 4.
            FindAllCustomersByOrdersIn1997AndShippedToCanadaNative();
            Console.WriteLine();

            // 5.
            string region = "Lara";
            DateTime startDate = new DateTime(1996, 10, 16);
            DateTime endDate = new DateTime(1996, 11, 13);
            var orders = FindAllOrdersRegionAndPeriod(region, startDate, endDate);
            foreach (var order in orders)
            {
                Console.WriteLine(order.OrderDate + "->" + order.RequiredDate + "->" + order.ShipRegion);
            }
            Console.WriteLine();

            // 6. Use SQL Server Management Objects (SMO) library installed with NuGet Packages

            // Change server name for your computer
            var server = new Server(@"DESKTOP-CTR5RI6\SQLEXPRESS");
            Database newdb = new Database(server, "NorthwindTwin");
            newdb.Create();

            Transfer transfer = new Transfer(server.Databases["Northwind"]);
            transfer.CopyAllObjects = true;
            transfer.CopyAllUsers = true;
            transfer.Options.WithDependencies = true;
            transfer.DestinationDatabase = newdb.Name;
            transfer.DestinationServer = server.Name;
            transfer.DestinationLoginSecure = true;
            transfer.CopySchema = true;
            transfer.CopyData = true;
            transfer.Options.ContinueScriptingOnError = true;
            transfer.TransferData();

            // 7. 
            var db1 = new NorthwindEntities();
            var db2 = new NorthwindEntities();

            var customer1 = db1.Customers.Where(cust => cust.ContactName == "Ana Trujillo").FirstOrDefault();
            var customer2 = db1.Customers.Where(cust => cust.ContactName == "Ana Trujillo").FirstOrDefault();

            customer1.ContactName = "Pesho";
            customer2.ContactName = "Gosho";

            db1.SaveChanges();
            db2.SaveChanges();

            db1.Dispose();
            db2.Dispose();
            //Concurrency control
            //Entity Framework uses optimistic concurrency control (no locking by default)
            //Provides automatic concurrency conflict detection and means for conflicts resolution

            // 8. EmployeeExtension
        }

        private static List<Order> FindAllOrdersRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            List<Order> result;
            using (var db = new NorthwindEntities())
            {
                result = db.Orders
                    .Where(ord => ord.OrderDate.Value == startDate && 
                        ord.RequiredDate.Value == endDate && ord.ShipRegion == region)
                    .Select(order => order)
                    .ToList();
            }
            return result;
        }

        private static void FindAllCustomersByOrdersIn1997AndShippedToCanadaNative()
        {
            NorthwindEntities context = new NorthwindEntities();
            string nativeSQLQuery =
              "SELECT * FROM Customers c " +
              "INNER JOIN Orders o " +
              "ON c.CustomerID = o.CustomerID " +
              "WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada' ";

            var customersNative = context.Database.SqlQuery<Customer>(nativeSQLQuery);
            foreach (var custNative in customersNative)
            {
                Console.WriteLine(custNative.ContactName);
            }

            context.Dispose();
        }

        private static List<Customer> FindAllCustomersByOrdersIn1997AndShippedToCanada()
        {
            List<Customer> result;
            using(var db = new NorthwindEntities())
            {
                result = db.Orders
                    .Where(ord => ord.OrderDate.Value.Year == 1997 && ord.ShipCountry == "Canada")
                    .Select(cus => cus.Customer)
                    .ToList();
            }
            return result;
        }
    }
}
