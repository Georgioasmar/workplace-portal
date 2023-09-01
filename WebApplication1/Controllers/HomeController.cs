using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;
using Business.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly HrDbContext _context;

        public HomeController(HrDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Employee model)
        {
            if (ModelState.IsValid)
            {
                var employee = _context.Employees.FirstOrDefault(e => e.User == model.User && e.Pass == model.Pass);
                if (employee != null)
                {
                    // Authentication successful
                    // You can implement further logic like setting authentication cookies
                    return RedirectToAction("Index", "Menu"); // Replace with your desired action
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }
            return View(model);
        }

        private void DepComboRefresh()
        {
            var existingDepartments = _context.Departments.Select(dep => dep.depName).ToList();

            // Create a script block to call the refreshDepartments function
            var script = $"refreshDepartments({JsonConvert.SerializeObject(existingDepartments)});";
            ViewData["RefreshScript"] = new HtmlString(script);
        }

        // Inside EmployeeManagerController
        public IActionResult EmpCreation()
        {
            DepComboRefresh();
            return View();
        }
    }
}
