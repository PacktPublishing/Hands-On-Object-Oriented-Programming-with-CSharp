using System.Data.SqlClient;
using System;
using System.Data;

public class Program
{
    public static void Main()
    {
        string ConnectionString = "Integrated Security = SSPI; Initial Catalog= Northwind; Data source = localhost; ";
        SqlConnection conn = new SqlConnection(ConnectionString);
        String sql = "InsertPerson";
        SqlCommand command = new SqlCommand(sql, conn);
        command.CommandType = CommandType.StoredProcedure;
        SqlParameter param = command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 11);
        param.Value = "Raihan";
        param = command.Parameters.Add("@LastName", SqlDbType.NVarChar, 11);
        param.Value = "Taher";
        conn.Open();
        int rowsAffected = command.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine(rowsAffected);
    }
}