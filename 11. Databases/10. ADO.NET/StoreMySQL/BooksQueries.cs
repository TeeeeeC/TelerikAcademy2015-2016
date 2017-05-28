namespace StoreMySQL
{
    using System;

    using MySql.Data;
    using MySql.Data.MySqlClient;

    internal class BooksQueries
    {
        private static MySqlConnection conn;
        internal static void Main()
        {
            Console.Write("Enter pass: ");
            string pass = Console.ReadLine();

            // Create store database with MySQL Workbench, then
            string connectionStr = "Server=localhost; Database=store; Port=3306; Uid=root; Pwd=" + pass + ";";
            conn = new MySqlConnection(connectionStr);
            conn.Open();
            using (conn)
            {
                MySqlCommand command = new MySqlCommand(
                    "CREATE TABLE Books " +
                    "( " +                      
	                "    BookID int NOT NULL AUTO_INCREMENT, " +                
	                "    Title nvarchar(100) NOT NULL, " +            
	                "    ISBN nvarchar(100) NOT NULL, " +             
	                "    PublishDate date NOT NULL, " +              
	                "    CONSTRAINT PK_Books PRIMARY KEY (BookID) " +   
                    ");", conn);
                command.ExecuteNonQuery();
                Console.WriteLine("The Books table is created in store database!");

                var book = new Book
                {
                    Title = "C# masters",
                    ISBN = "43243242",
                    Date = DateTime.Today
                };

                AddBook(book);
                AddBook(book);

                ListAllBooks();

                var title = "C# masters";
                bool foundBook = FindBookByTitle(title);
                Console.WriteLine("FoundBook: {0}", foundBook);
            }
        }

        private static bool FindBookByTitle(string title)
        {
            MySqlCommand cmdFindBook = new MySqlCommand("SELECT Title FROM Books WHERE Title = '" + title + "'", conn);
            MySqlDataReader reader = cmdFindBook.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string titleFound = (string)reader["Title"];
                    if (titleFound != string.Empty)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static void ListAllBooks()
        {
            MySqlCommand cmdListAllBooks = new MySqlCommand("SELECT * FROM Books", conn);
            MySqlDataReader reader = cmdListAllBooks.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string title = (string)reader["Title"];
                    string iSBN = (string)reader["ISBN"];
                    DateTime date = (DateTime)reader["PublishDate"];
                    Console.WriteLine("{0} -> {1} -> {2}", title, iSBN, date.ToString());
                }
            }
        }

        private static void AddBook(Book book)
        {
            MySqlCommand cmdInsertBook = new MySqlCommand(
                "INSERT INTO Books(Title, ISBN, PublishDate) " +
                "VALUES (@title, @iSBN, @publishDate)", conn);

            cmdInsertBook.Parameters.AddWithValue("@title", book.Title);
            cmdInsertBook.Parameters.AddWithValue("@iSBN", book.ISBN);
            cmdInsertBook.Parameters.AddWithValue("@publishDate", book.Date);

            cmdInsertBook.ExecuteNonQuery();
            Console.WriteLine("Book added!");
        }
    }
}
