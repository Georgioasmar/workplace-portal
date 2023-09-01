using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GoToEmployeeManager()
        {
            return RedirectToAction("Employees", "EmployeeManager");
        }
    }
}
