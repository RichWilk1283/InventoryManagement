using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
  public class InventoryManagementServices
  {
    public string Name { get; set; }
    public List<InventoryItem> InventoryList { get; set; }

    public InventoryManagementServices(string name)
    {
      InventoryList = new List<InventoryItem>();
      Name = name;
      Console.WriteLine($"Hello, {Name}");
    }

    public void Menu()
    {
      Console.WriteLine("Menu:");
      Console.WriteLine("Option 1: List Inventory Items.");
      Console.WriteLine("Option 2: Add Inventory Items.");
      Console.WriteLine("Option 3: Clear individual Inventory Item.");
      Console.WriteLine("Option 4: Clear all Inventory Items.");

      Console.WriteLine("Please enter your option (1-4)");

      int option = Int32.Parse(Console.ReadLine());

      if (option != 1 && option != 2 && option != 3 && option != 4)
      {
        Console.WriteLine("Please make a valid selection");
        Menu();
      }
      else
      {
        MenuSelection(option);
      }
    }

    public void MenuSelection(int option)
    {
      switch (option)
      {
        case 1:
          GetInventory();
          break;
        case 2:
          createInventoryItem();
          break;
        case 3:
          ClearItem();
          break;
        case 4:
          ClearAll();
          break;
      }
    }

    public void GetInventory()
    {
      Console.WriteLine($"{Name}, has the following intems:");
      if (InventoryList.Count == 0)
      {
        Console.WriteLine("Nothing in list.");

      }
      else
      {
        foreach (var item in InventoryList)
        {
        
          Console.WriteLine(item);          
        }
      }
    }

    public void createInventoryItem()
    {
      InventoryItem item = new InventoryItem();
      Console.WriteLine("Please enter the name of the item:");
      item.Name = Console.ReadLine();
      Console.WriteLine("Please enter the description of the item:");
      item.Description = Console.ReadLine();
      Console.WriteLine("Please enter the value of the item:");
      item.Value = Int32.Parse(Console.ReadLine());
      Console.WriteLine("Please enter the category of the item:");
      item.Category = Category.Conservatory;


      Console.WriteLine($"You have created: {item.Name}");

      AddInventoryItemToDb(item);
      Menu();
    }

    public void AddInventoryItemToDb(InventoryItem item)
    {
      Console.WriteLine("Mock: Added to DB");

    }

    public void ClearItem()
    {
      Console.WriteLine("Testing ClearItem");
    }

    public void ClearAll()
    {
      Console.WriteLine("Testing ClearAll");
    }
  }
}
