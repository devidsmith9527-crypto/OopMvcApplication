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
    [Route("Students")]
    public class StudentController : Controller
    {
        [HttpGet("all")]
        public IActionResult Index() {
            List<Student> students = new() {
                new(1, "Dara SOK", "Computer Science"), 
                new(2, "Cheata SENG", "Information Technology"),
                new(3, "Sopheap CHHAY", "Software Engineering"),
                new(4, "Sokha CHHAY", "Computer Science"),
                new(5, "Sophal CHHAY", "Information Technology"),
                new(6, "Sophal CHHAY", "Software Engineering")
            };
            return View(students);
        }
    }
}