using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
  public class InventoryItem
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }
    public Category Category { get; set; }
  }
}
