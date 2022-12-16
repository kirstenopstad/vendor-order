using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    // properties
    public string Name { get; set; }
    public string Description { get; set; }
    private List<Vendor> _instances = new List<Vendor> {};

    // constructor 
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
    }
    // methods
    
  }
}
