using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVC_RazorSyntax_Demo.Models; // Add this line;

 namespace MVC_RazorSyntax_Demo
{
    public class StudentController : Controller
    {
        private readonly List<Student> students; // Correct the type here

        public StudentController()
        {
            students = new List<Student>() // Correct the type here
            {
                new Student(){Id= 1, Name="Rupesh", Marks= 90},
                new Student(){Id= 2, Name="Rupesh", Marks= 80},
                new Student(){Id= 3, Name="Rupesh", Marks= 70},
                new Student(){Id= 4, Name="Rupesh", Marks= 60},
                new Student(){Id= 5, Name="Rupesh", Marks= 70},
                new Student(){Id= 6, Name="Rupesh", Marks= 60}
            };
        }

        public IActionResult Index()
        {
            var studlist = students;
            return View(studlist);
        }
    }
}