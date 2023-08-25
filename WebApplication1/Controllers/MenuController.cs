using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicatio1.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserIsAdmin = Business.Controllers.HomeController.loggedemp.isAdmin;
            return View();
        }
    }
}
