using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OopMvcApplication.Controllers
{
    [Route("Products")]
    public class ProdutsController : Controller
    {

        [HttpGet("Index")]
        public IActionResult Index()
        {
            ViewData["PageTitle"] = "List of Products";
            ViewBag.ProductID = "Pro-0001";
            ViewBag.ProductName = "Laptop";
            ViewBag.ProductPrice = 1000;
            ViewBag.ProductDescription = "This is a high-end laptop with powerful performance and sleek design.";
            return View();
        }
        
        [HttpGet("Customer")]
        public IActionResult Customer()
        {
            ViewData["PageTitle"] = "List of Customers";
            ViewBag.CustomerID = "Cust-0001";
            ViewBag.CustomerName = "John Doe";
            ViewBag.CustomerEmail = "john.doe@example.com";
            return View();
        }

    }
}