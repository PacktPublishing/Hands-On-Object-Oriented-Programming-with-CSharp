using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace CommandTypeEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a connection string
            string ConnectionString = "Integrated Security = SSPI; " +
            "Initial Catalog= Northwind; " + " Data source = localhost; ";
            string SQL = "SELECT * FROM Customers";
            // create a connection object
            SqlConnection conn = new SqlConnection(ConnectionString);
            // Create a command object
            SqlCommand cmd = new SqlCommand(SQL, conn);
            conn.Open();
            // Call ExecuteReader to return a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("customer ID, Contact Name, " + "Contact Title, Address ");
            Console.WriteLine("=============================");
            while (reader.Read())
            {
                Console.Write(reader["CustomerID"].ToString() + ", ");
                Console.Write(reader["ContactName"].ToString() + ", ");
                Console.Write(reader["ContactTitle"].ToString() + ", ");
                Console.WriteLine(reader["Address"].ToString() + ", ");
            }
            //Release resources
            reader.Close();
            conn.Close();
        }
    }
}