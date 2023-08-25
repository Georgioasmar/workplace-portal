using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Business.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace Business.Controllers
{
    public class DbController : Controller
    {
        private readonly HrDbContext _context;

        public DbController(HrDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()              //function to load DataBases menu
        {
            return View();
        }

        public IActionResult EmpDb(string searchTerm)             //function redirects to EmpDb and Loads table and refresh Table if a searchTerm was eneterd
        {
            var employeesQuery = _context.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                employeesQuery = employeesQuery.Where(e => e.Name.Contains(searchTerm));
            }

            var employees = employeesQuery.ToList();

            return View(employees);
        }

        public IActionResult EmpCrea()
        {
            DepComboRefresh();
            IDComboRefresh();
            return View();

        }


        private void DepComboRefresh()
        {
            var depNameSet = new HashSet<string>(); // Create a HashSet to store unique department names

            var depOptions = _context.Departments.Select(dep => dep.depName).ToList();
            foreach (var depName in depOptions)
            {
                if (!depNameSet.Contains(depName))
                {
                    depNameSet.Add(depName); // Add the department name to the HashSet if not already present
                }
            }

            ViewData["DepOptions"] = depNameSet.ToList(); // Convert the HashSet to a List for ViewData

        }

        [HttpGet, ActionName("GetFieldOptions")]
        public JsonResult GetFieldOptions(string department)
        {
            var fieldOptions = _context.Departments
                .Where(dep => dep.depName == department)
                .Select(dep => dep.depPos)
                .ToList();
            Console.WriteLine(fieldOptions);
            return Json(fieldOptions); // Return the field options as JSON
        }
        [HttpGet]
        public JsonResult GetFullPosOptions(string Field)
        {
            var positions = _context.Positions.ToList(); // Fetch all positions

            var processedPositions = positions.Select(pos => ProcessFieldText(pos.PosName, Field))
                                              .ToList(); // Process each position

            return Json(processedPositions); // Return processed positions as JSON
        }


        private void IDComboRefresh()
        {
            var idSet = new HashSet<int>(); // Create a HashSet to store unique id

            var idOptions = _context.Employees.Select(emp => emp.Id).ToList();
            foreach (var id in idOptions)
            {
                if (!idSet.Contains(id))
                {
                    idSet.Add(id); // Add the id to the HashSet if not already present
                }
            }

            ViewData["idOptions"] = idSet.ToList(); // Convert the HashSet to a List for ViewData

        }

        //public IActionResult GetEmployeeNameById(int id)
        //{
        //    string employeeName = _context.Employees
        //        .Where(emp => emp.Id == id)
        //        .Select(emp => emp.Name)
        //        .FirstOrDefault();

        //    return Json(employeeName);
        //}

        [HttpPost]
        public ActionResult Post(Employee person)
        {
            saveEmp(person);
            return RedirectToAction("EmpCrea"); ;
        }


        public void saveEmp(Employee person)
        {
            string employeeName = Functions.CapitalizeFirstLetterOfWords(person.Name);

            var isAdmin = person.isAdmin;
            var resetNext = person.resetNext;

            if (person.Id == -1)
            {
                Employee newEmployee = new Employee();

                //int Id = person.Id; keep id null so SQL auto increments
                newEmployee.Name = employeeName;
                newEmployee.User = person.User;
                newEmployee.Pass = person.Pass;
                newEmployee.Phone = person.Phone;
                newEmployee.Address = person.Address;
                newEmployee.Email = person.Email;
                newEmployee.Dep = person.Dep; 
                newEmployee.Pos = person.Pos;
                newEmployee.FullPos = person.FullPos;
                newEmployee.isAdmin = person.isAdmin;
                newEmployee.resetNext = person.resetNext;
                newEmployee.countryCode = person.countryCode;

                Console.WriteLine(" new admin = "+ isAdmin +"existing admin: " + newEmployee.isAdmin);

                _context.Employees.Add(newEmployee);

            }
            else
            {
                Employee existingEmployee = _context.Employees.FirstOrDefault(emp => emp.Id == person.Id);
                if (existingEmployee != null)
                {
                    // Update the properties of the existing employee entity
                    existingEmployee.Name = employeeName;
                    existingEmployee.User = person.User;
                    existingEmployee.Pass = person.Pass;
                    existingEmployee.Phone = person.Phone;
                    existingEmployee.Address = person.Address;
                    existingEmployee.Email = person.Email;
                    existingEmployee.Dep = person.Dep;
                    existingEmployee.Pos = person.Pos;
                    existingEmployee.FullPos = person.FullPos;
                    existingEmployee.isAdmin = person.isAdmin;
                    existingEmployee.resetNext = person.resetNext;
                    existingEmployee.countryCode = person.countryCode;

                    Console.WriteLine(" new admin = " + isAdmin + "existing admin: " + existingEmployee.isAdmin);

                }
            }
            

            _context.SaveChanges();
        }

        [HttpGet]
        public IActionResult GetEmployeeInfoById(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);

            if (employee != null)
            {
                var employeeInfo = new
                {

                    Name = employee.Name,
                    Email = employee.Email,
                    Address = employee.Address,
                    Phone = employee.Phone,
                    CountryCode = employee.countryCode,
                    Dep = employee.Dep,
                    Field = employee.Pos,
                    FullPos = employee.FullPos,
                    User = employee.User,
                    Pass = employee.Pass,
                    isAdmin = employee.isAdmin,
                    resetNext = employee.resetNext

                    // Add other properties as needed
                };

                return Json(employeeInfo);
            }
            else
            {
                return NotFound(); // Return a 404 response if employee is not found
            }
            
        }

        public string ProcessFieldText(string posText, string txtPos)
        {
            // Retrieve the corresponding depPos using LINQ from the provided list
            string dash = txtPos;

            //if (dash == null)
            //{
            //    return "hi"; // Department not found, return "hi"
            //}

            string star = _context.Departments.FirstOrDefault(dep => dep.depPos == txtPos)?.depName;

            // Replace '*' with the star string and '-' with the dash string
            string result = posText.Replace("*", star).Replace("-", dash);

            return result; // Return the processed result
        }


        [HttpGet]
        public IActionResult PhoneCheck(string phoneNumber, int userId)
        {
            bool phoneNumberExists = _context.Employees.Any(u => u.Phone == phoneNumber && u.Id != userId); // Adjust the property and class names as per your model
            //bool isCurrentUser = !_context.Employees.Any(u => u.Phone == phoneNumber && u.Id == userId); // Check if the phone number exists for another user

            return Json(new { exists = phoneNumberExists});
        }


        [HttpGet]
        public IActionResult EmailCheck(string email, int userId)
        {
            Console.WriteLine("email: " + email+ " and ID: " +userId);
            bool emailExists = _context.Employees.Any(u => u.Email.ToLower() == email.ToLower() && u.Id != userId); // Adjust the property and class names as per your model
            //bool isCurrentUser = !_context.Employees.Any(u => u.Phone == phoneNumber && u.Id == userId); // Check if the phone number exists for another user
            Console.WriteLine("email already exists: " + emailExists);
            return Json(new { exists = emailExists });
        }

        [HttpGet]
        public IActionResult UsernameCheck(string user, int userId)
        {
            Console.WriteLine("username: " + user + " and ID: " + userId);
            bool userExists = _context.Employees.Any(u => u.User.ToLower() == user.ToLower() && u.Id != userId); // Adjust the property and class names as per your model
            //bool isCurrentUser = !_context.Employees.Any(u => u.Phone == phoneNumber && u.Id == userId); // Check if the phone number exists for another user
            Console.WriteLine("username already exists: " + userExists);
            return Json(new { exists = userExists });
        }




        //public IActionResult GetFieldOptionsByDepartment(string department)
        //{
        //    List<string> fieldOptions = FetchFieldOptionsFromServer(department); // Implement this

        //    return Json(fieldOptions);
        //}
        //private List<string> FetchFieldOptionsFromServer(string department)
        //{ 
        //    var fieldOptions = _context.Departments
        //    .Where(dep => dep.depName == department)
        //    .Select(dep => dep.depPos)
        //    .ToList();

        //    return fieldOptions;
        //}


    }
}
