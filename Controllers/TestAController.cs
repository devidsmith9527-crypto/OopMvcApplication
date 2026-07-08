using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OopMvcApplication.Controllers
{
    [Route("TestA")]
    public class TestAController : Controller
    {
        

        [HttpGet("Test1")]
        public IActionResult Test1()
        {
            return View();
        }


    }
}