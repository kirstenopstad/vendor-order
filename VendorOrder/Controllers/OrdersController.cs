using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

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
  }
}