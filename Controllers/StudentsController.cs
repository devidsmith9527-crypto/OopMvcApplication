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

        [HttpGet("Home")]//Attribute Route
        public IActionResult Index()
        {
            ViewBag.Student = "Soeurng Lim";

            return View();
        }

        [HttpGet("Info")] //Attribute Route
        public IActionResult StudentInfo()
        {
            ViewBag.name = "Soeurng Lim";
            ViewBag.gender = "Male";
            return View();
        }

        [HttpGet("List")]//Attribute Route
        public IActionResult Students_List()
        {
            List<string> students = new(){"Dara","Kolab","Sophy"};
            ViewBag.students = students;
            return View(ViewBag.students);
        }
        
    }
}