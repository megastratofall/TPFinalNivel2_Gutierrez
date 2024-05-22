using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

public class DatabaseHelper
{
    private string connectionString;

    public DatabaseHelper()
    {
        connectionString = ConfigurationManager.ConnectionStrings["CatalogoDbConnectionString"].ConnectionString;
    }

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public bool TestConnection()
    {
        try
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                return true; 
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error de conexión: " + ex.Message);
            return false; 
        }
    }
}
