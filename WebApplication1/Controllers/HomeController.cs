using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicatio1.Models;
using Business.Models;

namespace Business.Controllers
{
    
    public class HomeController : Controller
    {
        public static Employee loggedemp;

        private readonly ILogger<HomeController> _logger;
        private readonly HrDbContext _context;

        public HomeController(ILogger<HomeController> logger, HrDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
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
                    Console.WriteLine("loggedemp admin = " + loggedemp.isAdmin);
                    return RedirectToAction("Index", "Menu"); // Replace with your desired action
                }
                else
                {
                    // Set error codes based on specific conditions
                    if (string.IsNullOrEmpty(model.User) && string.IsNullOrEmpty(model.Pass))
                    {
                        TempData["ErrorCode"] = 4;
                    }
                    else if (string.IsNullOrEmpty(model.User))
                    {
                        TempData["ErrorCode"] = 2; // Username field is empty
                    }
                    else if (string.IsNullOrEmpty(model.Pass))
                    {
                        TempData["ErrorCode"] = 3; // Password field is empty
                    }
                    else
                    {
                        TempData["ErrorCode"] = 1; // Username or password is incorrect
                    }

                    return RedirectToAction("Index"); // Redirect back to the Index view
                }
            }

            return View(model);
        }


    }
}
