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

    public InventoryItem createInventoryItem()
    {
      return new InventoryItem();
    }

    public void AddInventory(string name, string description, int value, string cat)
    {
      Console.WriteLine("Testing AddInventory");

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
