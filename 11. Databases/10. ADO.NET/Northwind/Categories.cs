namespace Northwind
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;

    internal class Categories
    {
        private static SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                "Database=Northwind; Integrated Security=true");

        private const string DEST_IMAGE_FILE_NAME =
        @"..\..\image.jpg";
        internal static void Main()
        {
            dbCon.Open();
            using(dbCon)
            {
                // 1.
                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int categoriesCount = (int)cmdCount.ExecuteScalar();
                Console.WriteLine("Categories: {0}", categoriesCount);
                Console.WriteLine();

                // 2. 
                SqlCommand cmdNameAndDescription = new SqlCommand(
                    "SELECT CategoryName, Description  FROM Categories", dbCon);
                SqlDataReader reader = cmdNameAndDescription.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("{0}->{1}", categoryName, description);
                    }
                }
                Console.WriteLine();

                // 3. 
                SqlCommand cmdCategoryNameAndProductName = new SqlCommand(
                    "SELECT Categories.CategoryName, Products.ProductName" +
                    " FROM Categories" +
                    " INNER JOIN Products" +
                    " ON Categories.CategoryID = Products.CategoryID", dbCon);

                reader = cmdCategoryNameAndProductName.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];
                        Console.WriteLine("{0}->{1}", categoryName, productName);
                    }
                }
                Console.WriteLine();

                // 4.
                var product = new Product
                {
                    ProductName = "Coca cola",
                    SupplierID = 1,
                    CategoryID = 1,
                    QuantityPerUnit = "6 - 330 ml bottles",
                    UnitPrice = 14,
                    UnitsInStock = 20,
                    UnitsOnOrder = 1,
                    ReorderLevel = 6,
                    Discontinued = false
                };

                int newProductId = InsertProduct(product);
                Console.WriteLine("Inserted new product. " + "ProductID = {0}", newProductId);
                Console.WriteLine();

                // 5.
                ExtractImageFromDB();
                Console.WriteLine();

                // 8.
                Console.Write("Enter text for search by ProductName: ");
                string input = Console.ReadLine();
                //input = EscapeSpecialCharacters(input);
                SqlCommand cmdSearchProductName = new SqlCommand(
                    "SELECT ProductName FROM Products WHERE CHARINDEX('" + input + "', ProductName) > 0", dbCon);
                reader = cmdSearchProductName.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string result = (string)reader["ProductName"];
                        Console.Write("{0}, ", result);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int InsertProduct(Product product)
        {
            SqlCommand cmdInsertProduct = new SqlCommand(
                "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, " +
                    "UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                "VALUES (@productName, @supplierID, @categoryID, @quantityPerUnit, " +
                    "@unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued) ", dbCon);

            cmdInsertProduct.Parameters.AddWithValue("@productName", product.ProductName);
            cmdInsertProduct.Parameters.AddWithValue("@supplierID", product.SupplierID);
            cmdInsertProduct.Parameters.AddWithValue("@categoryID", product.CategoryID);
            cmdInsertProduct.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit);
            cmdInsertProduct.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            cmdInsertProduct.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
            cmdInsertProduct.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder);
            cmdInsertProduct.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
            cmdInsertProduct.Parameters.AddWithValue("@discontinued", product.Discontinued);

            cmdInsertProduct.ExecuteNonQuery();

            SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
            int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
            return insertedRecordId;
        }

        private static void ExtractImageFromDB()
        {

            SqlCommand cmd = new SqlCommand(
                "SELECT Picture FROM Categories", dbCon);

            SqlDataReader reader = cmd.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    byte[] image = (byte[])reader["Picture"];
                    Console.WriteLine("Extracted image from the DB.");

                    WriteBinaryFile(DEST_IMAGE_FILE_NAME, image);
                    Console.WriteLine("Image saved to file {0}.", DEST_IMAGE_FILE_NAME);
                }
                else
                {
                    throw new Exception(
                        String.Format("Invalid image"));
                }
            }
        }

        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }
    }
}
