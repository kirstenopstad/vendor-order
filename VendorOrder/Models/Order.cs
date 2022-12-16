using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    // properties
    public string Title { get; set; }
    public string Description {get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private List<Order> _instances = new List<Order> {};

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
  }
}
