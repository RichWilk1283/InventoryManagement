
using InventoryManagement;
using System.ComponentModel.Design;

public class Program
{
  private static void Main(string[] args)
  {
    bool printDebugMode = false;

    static string companyName()
    {
      Console.WriteLine("Welcome to inventory management app.");
      Console.WriteLine("Please name your company");

      string name = Console.ReadLine();


      return name;
    }

    var companyInventoryManagement = new InventoryManagementServices(companyName());

    companyInventoryManagement.Menu();
  }
}