using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OopMvcApplication.Controllers
{
    //[Route("[controller]")]
    public class StudentsController : Controller
    {        

        //[HttpGet]
        public IActionResult Index()
        {
            ViewBag.Student = "Soeurng Lim";

            return View();
        }

        public IActionResult StudentInfo()
        {
            ViewBag.name = "Soeurng Lim";
            ViewBag.gender = "Male";
            return View();
        }

        
    }
}