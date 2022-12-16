using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    // properties
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public string Description {get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    // constructor
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // methods
    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void Delete(Order order)
    {
      _instances.Remove(order);
    }
  }
}