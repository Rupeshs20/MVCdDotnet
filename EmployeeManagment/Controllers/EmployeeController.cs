 using System.Collections.Generic;
using System.Linq;
using EmployeeManagment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // In-memory list to simulate a database
        private readonly List<EmployeeModel> employees;

        public EmployeeController()
        {
            employees = new List<EmployeeModel>
            {
                new EmployeeModel { Id = 1, Name = "Rupesh Shinde", Salary = 50000 },
                new EmployeeModel { Id = 2, Name = "Pratik Swanat", Salary = 60000 },
                new EmployeeModel { Id = 3, Name = "Chaitali B", Salary = 55000 },
                new EmployeeModel { Id = 4, Name = "Aditya K", Salary = 65000 },
                new EmployeeModel { Id = 5, Name = "Yogiraj J", Salary = 70000 }
            };
        }

        // GET: Employee
        public IActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
    }
}