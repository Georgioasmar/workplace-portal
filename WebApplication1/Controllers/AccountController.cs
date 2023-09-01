using Microsoft.AspNetCore.Mvc;
using Business.Models;  // You'll need to adjust the namespace as per your project structure
using System.Linq;
//using Business.Models;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;



namespace Business.Controllers
{
    public class AccountController : Controller
    {
        private readonly HrDbContext _context;

        public AccountController(HrDbContext context)
        {
            _context = context;
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
    }



}
