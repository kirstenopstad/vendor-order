using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index() 
    { 
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors); 
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      // Create new vendor
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      // Create dictionary to return multiple objects (vendor and orders)
      Dictionary<string, object> model = new Dictionary<string, object>() {};
      // Get vendor obj
      Vendor foundVendor = Vendor.Find(vendorId);
      // TODO: Get list of instances of orders relating to this vendor [GetAll()]
      List<Order> vendorOrders = foundVendor.Orders;
      // Add to dictionary
      model.Add("vendor", foundVendor);
      model.Add("orders", vendorOrders);
      // Return Show and pass in model
      return View("Show", model);
    }

    // Creates new orders and adds to vendor order list
    // [HttpPost("/vendors/{vendorId}/orders")]
    // public ActionResult Create(int vendorId, string title, string description, int price, string date)
    // {
    //   // Create order
    //   Order newOrder = new Order(title, description, price, date);
    //   // Add order to vendor orders list
    //   Vendor selectedVendor = Vendor.Find(vendorId);
    //   selectedVendor.AddOrder(newOrder);
    //   return RedirectToAction("Show", vendorId);
    // }
  }
}