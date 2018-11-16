using System.Data.SqlClient;
using System;
using System.Data;
using System.Data.Odbc;
public class Program
{
    public static void Main()
    {
        string connectionString = "Data Source=Oracle9i;User ID=*****;Password=*****;";
        OdbcConnection odbcConnection = new OdbcConnection(connectionString);
        string sql = "SELECT * FROM Person";
        OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
        odbcConnection.Open();
        OdbcDataReader odbcReader = odbcCommand.ExecuteReader();
        while (odbcReader.Read())
        {
            Console.WriteLine("FirstName " + odbcReader["FirstName"] + " LastName  " + odbcReader["LastName"]);
        }
        odbcConnection.Close();
    }
}