 using Microsoft.AspNetCore.Mvc;
using MVC_EmployeeCRUD_Demo.Models;

namespace MVC_EmployeeCRUD_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = EmployeeService.GetAllEmployees();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee newEmployee)
        {
            EmployeeService.AddEmployee(newEmployee);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = EmployeeService.GetEmployeeById(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            EmployeeService.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var employee = EmployeeService.GetEmployeeById(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = EmployeeService.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        
        public IActionResult Delete(int id, Employee emp){
            var emp1 = EmployeeService.GetEmployeeById(emp.EmpId);

            if(emp1 == null)
           return View();
           else
           {
            EmployeeService.DeleteEmployee(emp.EmpId);
            return RedirectToAction("Index");
           }
        }
}
}