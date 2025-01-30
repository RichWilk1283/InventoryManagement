using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
  public class DbServices
  {
    private static string connectionString = "Data Source=inventory.db;Version=3;";

    public static void InitialiseDb()
    {
      using (var connection = new SqliteConnection(connectionString))
      {
        connection.Open();
        string tableQuery = @"";
        SqliteCommand command = new SqliteCommand(tableQuery, connection);
        command.ExecuteNonQuery();
      }
    }
  }
}
