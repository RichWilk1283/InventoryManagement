
using InventoryManagement;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
  private static void Main(string[] args)
  {
    bool printDebugMode = false;

    Console.WriteLine("Welcome to inventory management app.");
    Console.WriteLine("Please name your company");

    string name = Console.ReadLine();


    var companyInventoryManagement = new InventoryManagementServices(name);

    companyInventoryManagement.Menu();
  }
}