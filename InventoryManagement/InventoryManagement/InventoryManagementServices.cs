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

      var option = Console.ReadLine();

      if (option != "1" && option != "2" && option != "3" && option != "4")
      {
        Console.WriteLine("Please make a valid selection");
        Menu();
      }
      else
      {
        int intOption = Int32.Parse(option);
        MenuSelection(intOption);
      }
    }

    public void MenuSelection(int option)
    {
      switch (option)
      {
        case 1:
          GetDbItems();
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

    public void GetDbItems()
    {
      var items = DbServices.GetItemsFromDb();
      Console.WriteLine(items.Count());
    }

    public void GetInventory()
    {
      int inventoryIndex = 0;
      Console.WriteLine($"{Name}, has the following intems:");
      if (InventoryList.Count == 0)
      {
        Console.WriteLine("Nothing in list.");
      }
      else
      {
        foreach (var item in InventoryList)
        {        
          Console.WriteLine($"{inventoryIndex} - {item.Name}, {item.Description}, {item.Value}, {item.Category}"); 
          inventoryIndex++;
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

      AddInventoryItemToList(item);
      Menu();
    }

    public void AddInventoryItemToList(InventoryItem item)
    {
      InventoryList.Add(item);
      Console.WriteLine($"Your inventory list now has {InventoryList.Count} item(s) in it.");
    }

    public void AddInventoryListToDb(List<InventoryItem> dbInventoryList)
    {
      //commit to SQLite
    }

    public void ClearItem()
    {
      Console.WriteLine("Testing ClearItem");
    }

    public void ClearAll()
    {
      InventoryList.Clear();
      Console.WriteLine("Your list has been cleared.");
    }
  }
}
