
using InventoryManagement;

internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Welcome to inventory management app.");
    Console.WriteLine("Please name your company");

    string name = Console.ReadLine();

    var newInventoryManagement = new InventoryManagementServices(name);
  }
}