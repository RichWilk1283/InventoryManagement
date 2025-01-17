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
    public Dictionary<string, int> InventoryList { get; set; }

    public InventoryManagementServices(string name)
    {
      InventoryList = new Dictionary<string, int>();
      Name = name;        
    }

    public void getInventory()
    {
      Console.WriteLine($"{Name}, has the following intems:");
      foreach (var item in InventoryList)
      {
        
        Console.WriteLine(item);          
      }
    }

    public void addInventory()
    {

    }
  }

}
