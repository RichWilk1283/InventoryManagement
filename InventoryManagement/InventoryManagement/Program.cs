
using InventoryManagement;
using System.ComponentModel.Design;

internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Welcome to inventory management app.");
    Console.WriteLine("Please name your company");

    string name = Console.ReadLine();


    var dkInventoryManagement = new InventoryManagementServices(name);

    Console.WriteLine("Menu:");
    Console.WriteLine("Option 1: List Inventory Items.");
    Console.WriteLine("Option 2: Add Inventory Items.");
    Console.WriteLine("Option 3: Clear individual Inventory Item.");
    Console.WriteLine("Option 4: Clear all Inventory Items.");

    Console.WriteLine("Please enter your option (1-4");
    
    int option = Int32.Parse(Console.ReadLine());
  }
}