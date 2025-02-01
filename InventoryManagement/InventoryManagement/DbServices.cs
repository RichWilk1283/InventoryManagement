using Microsoft.Data.Sqlite;

namespace InventoryManagement
{
  public class DbServices
  {
    private static string connectionString = "Data Source=inventory.db;";

    public static void InitialiseDb()
    {
      using (var connection = new SqliteConnection(connectionString))
      {
        connection.Open();

        string ItemsTableQuery = @"CREATE TABLE IF NOT EXISTS Items (
                                    item_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    item_name TEXT NOT NULL,
                                    item_description TEXT,
                                    item_value TEXT
                                  )";
        SqliteCommand commandItems = new SqliteCommand(ItemsTableQuery, connection);
        commandItems.ExecuteNonQuery();

        string customerTableQuery = @"CREATE TABLE IF NOT EXISTS Customer (
                                    customer_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    customer_firstname TEXT NOT NULL,
                                    customer_lastname TEXT NOT NULL,
                                    customer_email TEXT
                                  )";
        SqliteCommand commandCustomer = new SqliteCommand(customerTableQuery, connection);
        commandCustomer.ExecuteNonQuery();

        string addressTableQuery = @"CREATE TABLE IF NOT EXISTS Address (
                                    address_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    address_housenumber TEXT,
                                    address_housename TEX,
                                    address_line1 TEXT,
                                    address_line2 TEXT,
                                    address_postcode
                                  )";
        SqliteCommand commandAddress = new SqliteCommand(addressTableQuery, connection);
        commandAddress.ExecuteNonQuery();

      }
    }

    public static void DummyData()
    {
      using (var connection = new SqliteConnection(connectionString))
      {
        connection.Open();
        string insertItemQuery = "INSERT INTO Items (item_name, item_description, item_value) VALUES (@itemName, @itemDescription, @itemValue)";
        SqliteCommand command = new SqliteCommand(insertItemQuery, connection);
        command.Parameters.AddWithValue("@itemName", "Spoon_test");
        command.Parameters.AddWithValue("@itemDescription", "Something you eat with");
        command.Parameters.AddWithValue("@itemValue", "100");
        command.ExecuteNonQuery();
        Console.WriteLine("Item added successfully.");
        }
    }
  }
}
