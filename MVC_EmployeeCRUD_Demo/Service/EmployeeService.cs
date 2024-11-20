 using System.Collections.Generic;
using System.Linq;

namespace MVC_EmployeeCRUD_Demo.Models
{
    public class EmployeeService
    {
        private static List<Employee> employees;
        private static int nextId = 6;

        static EmployeeService()
        {
            employees = new List<Employee>
            {
                new Employee { EmpId = 1, FirstName = "John", LastName = "Doe", Salary = 50000 },
                new Employee { EmpId = 2, FirstName = "Jane", LastName = "Smith", Salary = 60000 },
                new Employee { EmpId = 3, FirstName = "Michael", LastName = "Johnson", Salary = 55000 },
                new Employee { EmpId = 4, FirstName = "Emily", LastName = "Davis", Salary = 70000 },
                new Employee { EmpId = 5, FirstName = "David", LastName = "Wilson", Salary = 65000 }
            };
        }

        public static List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public static Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.EmpId == id);
        }

        public static void AddEmployee(Employee employee)
        {
            employee.EmpId = nextId;
            employees.Add(employee);
            nextId++;
        }

        public static void UpdateEmployee(Employee modifiedEmployee)
        {
            int index = employees.FindIndex(e => e.EmpId == modifiedEmployee.EmpId);
            if (index != -1)
            {
                employees[index] = modifiedEmployee;
            }
        }

        public static void DeleteEmployee(int id)
        {
            var employee = GetEmployeeById(id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
    }
}