using System.Data.SqlClient;
using System;
using System.Data;
public class Program
{
    public static void Main()
    {
        string connectionString = "Data source = localhost;Initial Catalog=  TestDBForBook;Integrated Security = SSPI;";
        SqlConnection conn = new SqlConnection(connectionString);
        string sql = "UPDATE Food SET Discount = 5 WHERE Category = 'Breakfast'";
        SqlCommand command = new SqlCommand(sql, conn);
        conn.Open();
        int rowsAffected = command.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine("Number of rows inserted: " + rowsAffected);
    }
}