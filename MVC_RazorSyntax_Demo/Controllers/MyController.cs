 using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_RazorSyntax_Demo.Models;

namespace MVC_RazorSyntax_Demo.Controllers
{
    public class MyController : Controller
    { 
        public List<Student> students;

        public MyController()
        {
            students = new List<Student>(){
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
            ViewData["Message"] = "Hello from the controller!";
            return View();
        }

        public IActionResult ViewDataMethod()
        {
            ViewData["company"] = "YASH Technologies";
            ViewData["today"] = DateTime.Now.ToShortDateString();

            List<string> fruits = new List<string>(){
                "Apple", "Banana", "Orange", "Grapes", "Mango"
            };
            ViewData["fruits"] = fruits;
            ViewData["students"] = students;
            return View();
        }

        public IActionResult ViewBagMethod(){

            ViewBag.developername = "Rupesh Shinde";
            ViewBag.today=DateTime.Now.ToShortDateString();

            List<string> fruits = new List<string>(){
                "Apple", "Banana", "Orange", "Grapes", "Mango"
            };
            ViewBag.fruitlist=fruits;
            ViewBag.Studentlist=students;

            return View();
        }
    }
}