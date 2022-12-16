using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId) 
    { 
      Vendor selectedVendor = Vendor.Find(vendorId);
      return View(selectedVendor); 
    }

    // Finds single order by id
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      // Create dict to hold both vendor and order
      Dictionary<string, object> model = new Dictionary<string, object>() {};
      // Get Vendor, get Order
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);
      // Add to dict
      model.Add("vendor", foundVendor);
      model.Add("orders", foundOrder);
      // Return view Show() and pass in model
      return View("Show", model);
    }
  }
}