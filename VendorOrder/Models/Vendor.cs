using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    // properties
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    // constructor 
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    // methods
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void Delete(Vendor vendor)
    {
      _instances.Remove(vendor);
    }

    public void DeleteAllOrders()
    {
      Orders.Clear();
    }
  }
}
