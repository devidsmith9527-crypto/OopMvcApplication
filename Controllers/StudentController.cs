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
            List<Student> students = BindStudents();
            return View(students);
        }

        [HttpGet("details/{id}")]
        public IActionResult Detail(int id) {            
            List<Student> students = BindStudents();
            var student = students.FirstOrDefault(X => X.Id == id);
            if (student == null) {
                return NotFound();
            }
            return View(student);
        }

        private List<Student> BindStudents()
        {
            List<Student> students = new() {
                new(1, "Dara SOK", "Computer Science", "dara_sok", new DateTime(2000, 1, 1), "dara.sok@example.com"),
                new(2, "Cheata SENG", "Information Technology", "cheata_seng", new DateTime(2000, 2, 2), "cheata.seng@example.com"),
                new(3, "Sopheap CHHAY", "Software Engineering", "sopheap_chhay", new DateTime(2000, 3, 3), "sopheap.chhay@example.com"),
                new(4, "Sokha CHHAY", "Computer Science", "sokha_chhay", new DateTime(2000, 4, 4), "sokha.chhay@example.com"),
                new(5, "Sophal CHHAY", "Information Technology", "sophal_chhay", new DateTime(2000, 5, 5), "sophal.chhay@example.com"),
                new(6, "Sophal CHHAY", "Software Engineering", "sophal_chhay", new DateTime(2000, 6, 6), "sophal.chhay@example.com")
            };
            return students;
        }
    }
}