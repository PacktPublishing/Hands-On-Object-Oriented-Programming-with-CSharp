using System.Data.SqlClient;
using System;
using System.Data;

public class Program
{
    public static void Main()
    {
        string connectionString = "Data source = localhost;Initial Catalog=  TestDBForBook;Integrated Security = SSPI;";
        SqlConnection conn = new SqlConnection(connectionString);
        string sql = "SELECT * FROM Person";
        SqlCommand command = new SqlCommand(sql, conn);
        conn.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine("FirstName " + reader[1] + " LastName " +  reader[2]);
        }
        conn.Close();
    }
}