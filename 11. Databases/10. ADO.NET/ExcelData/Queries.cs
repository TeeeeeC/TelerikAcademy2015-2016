namespace ExcelData
{
    using System;
    using System.Data.OleDb;

    internal class Queries
    {
        internal static void Main()
        {
            string strExcelConn = "Provider=Microsoft.Jet.OLEDB.4.0;"
                                + "Data Source=data.xls;"
                                + "Extended Properties='Excel 8.0;HDR=Yes'";

            OleDbConnection connExcel = new OleDbConnection(strExcelConn);
            connExcel.Open();
            using (connExcel)
            {
                // 6.
                string sheet = @"SELECT * FROM [1$]";
                OleDbCommand cmdExcel = new OleDbCommand(sheet, connExcel);
                OleDbDataReader reader = cmdExcel.ExecuteReader();
                
                using(reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        double score = (double)reader["Score"];
                        Console.WriteLine("{0}->{1}", name, score);
                    }
                }

                Console.WriteLine();

                // 7.
                string query = @"INSERT INTO [1$] (Name, Score) VALUES('Pepa', 50)";
                cmdExcel.CommandText = query;
                cmdExcel.ExecuteNonQuery();
            }
        }
    }
}
