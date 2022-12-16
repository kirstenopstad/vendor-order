using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index() 
    { 
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors); 
    }
    // [HttpPost("")]

  }
}