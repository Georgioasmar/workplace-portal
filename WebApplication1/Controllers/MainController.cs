using Microsoft.AspNetCore.Mvc;
using Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;

namespace Business.Controllers

{

    
    public class MainController : Controller
    {
        public static Employee loggedemp { get; set; }

        private readonly HrDbContext _context;

        public MainController(HrDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Directly return the Login view
            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult toMenu()
        {
            // Directly return the Login view
            return View("~/Views/Menu/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Employee(string searchTerm)
        {
            // Directly return the Login view
            var employeesQuery = _context.Employees.AsQueryable(); // Create a queryable object

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Filter employees by name if searchTerm is provided
                employeesQuery = employeesQuery.Where(e => e.Name.Contains(searchTerm));
            }

            var employees = employeesQuery.ToList(); // Execute the query

            return View(employees);
        }

        public IActionResult toEmpCreator()
        {
            // Directly return the Login view
            return View("~/Views/EmployeeManager/EmpCreation.cshtml");
        }

        ////public IActionResult Login()
        ////{
        ////    return View();
        ////}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Employee model)
        {
            if (ModelState.IsValid)
            {
                var employee = _context.Employees.FirstOrDefault(e => e.User == model.User && e.Pass == model.Pass);
                if (employee != null)
                {
                    loggedemp = employee;
                    // Authentication successful
                    // You can implement further logic like setting authentication cookies
                    return View("~/Views/Menu/Index.cshtml");
                    //return RedirectToAction("Login", "Main"); // Replace with your desired action
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }
            return View(model);
        }


        //function(){
        // return RedirectToAction("Index", "Menu");}
        // call function in cshtml

        private void DepComboRefresh()
        {
            using (var context = _context) // Replace with your actual context creation
            {
                var existingDepartments = context.Departments.Select(dep => dep.depName).ToList();

                // Create a script block to call the refreshDepartments function
                var script = $"refreshDepartments({JsonConvert.SerializeObject(existingDepartments)});";
                ViewData["RefreshScript"] = new HtmlString(script);
            }
        }

        // Inside EmployeeManagerController
        public IActionResult EmpCreation()
        {
            DepComboRefresh();
            return View();
        }


        public IActionResult EmpTableSearch(string searchTerm)
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

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult GoToEmployeeManager()
        {
            return RedirectToAction("Employees", "Main");
        }
    }
}
