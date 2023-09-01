using Microsoft.AspNetCore.Mvc;
using Business.Models;
using System.Linq;

namespace Business.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private readonly HrDbContext _context;

        public EmployeeManagerController(HrDbContext context)
        {
            _context = context;
        }

        public IActionResult Employees(string searchTerm)
        {
            var employeesQuery = _context.Employees.AsQueryable(); // Create a queryable object

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Filter employees by name if searchTerm is provided
                employeesQuery = employeesQuery.Where(e => e.Name.Contains(searchTerm));
            }

            var employees = employeesQuery.ToList(); // Execute the query

            return View(employees);
        }

        //// Inside EmployeeManagerController
        //public IActionResult EmpCreation()
        //{
        //    AccountController.DepComboRefresh();
        //    return View();
        //}

        // Inside EmployeeManagerController
        [HttpPost]
        public IActionResult CreateEmployee(Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                // Add logic to save the new employee to the database
                // For example: _context.Employees.Add(newEmployee); _context.SaveChanges();

                return RedirectToAction("Employees");
            }
            return View("EmpCreation", newEmployee);
        }


    }
}
