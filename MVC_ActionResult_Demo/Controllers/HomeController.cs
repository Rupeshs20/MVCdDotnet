using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_ActionResult_Demo.Models;

namespace MVC_ActionResult_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index1()
        {
            return View("SecondView");
        }
         public IActionResult Index2()
        {
            return File("~/Files/TextFile.txt", "text/plain");
        }

          public IActionResult Index3()
        {
            return Json(new{ Name = "Rupesh", ID = 1});
        }
          public IActionResult Index4()
        {
            return RedirectToRoute(new{Controller = "Student", Action = "Index"});
        }

        public IActionResult SecondView()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
