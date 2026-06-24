using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OopMvcApplication.Models;
using Microsoft.Extensions.Logging;

namespace OopMvcApplication.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {      

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = new()
            {
                new Product(1, "iPhone 15 Pro", 999.00m, 2),
                new Product(2, "MacBook Pro M3", 1999.00m, 1),
                new Product(3, "iPad Air", 599.00m, 3),
                new Product(4,"Apple Watch Series 9", 399.00m, 1)
            };
            return View(products);            
        }

        
    }
}