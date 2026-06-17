using Microsoft.AspNetCore.Mvc;

namespace OopMvcApplication.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("Shop")]
        public IActionResult ShopInfo()
        {
            int shopId = 1;
            string shopName = "Angkor Tech Store";
            string address = "National Road 6, Siem Reap";
            string openHours = "8:00 AM - 8:00 PM";
            string pagetitle = "First Test MVC";

            ViewBag.ShopId = shopId;
            ViewBag.ShopName = shopName;
            ViewBag.Address = address;
            ViewBag.OpenHours = openHours;
            ViewBag.PageTitle = pagetitle;
            return View();
        }

        public IActionResult ProductList()
        {
            List<string> products = new() 
            { 
                "iPhone 15 Pro Max", 
                "MacBook Air M3", 
                "Apple Watch Series 9", 
                "AirPods Pro 2" 
            };

            ViewBag.Products = products;
            return View();
        }
    }
}