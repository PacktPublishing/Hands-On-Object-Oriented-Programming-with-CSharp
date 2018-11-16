using System.Data.SqlClient;
using System;
using System.Data;
public class Program
{
    public static void Main()
    {
        string connectionString = "Data source = localhost;Initial Catalog=  TestDBForBook;Integrated Security = SSPI;";
        SqlConnection conn = new SqlConnection(connectionString);
        string sql = "INSERT INTO Person (FirstName, LastName, Age) VALUES  ('John', 'Nash', 34)";
        SqlCommand command = new SqlCommand(sql, conn);
        conn.Open();
        int rowsAffected = command.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine("Number of rows inserted: " + rowsAffected);
    }
}