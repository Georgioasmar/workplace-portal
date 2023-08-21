using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class BusFuctions
    {
         public static void RetrieveDataByID(HrDbContext context, Employee employee)
        {
            var employeeFromDb = context.Employees.FirstOrDefault(e => e.Id == employee.Id);



            if (employeeFromDb != null)
            {
                // Populate the properties of the provided instance with data from the database
                employee.Name = employeeFromDb.Name;
                employee.Phone = employeeFromDb.Phone;
                employee.Job.Department = employeeFromDb.Job.Department;
            }
        }
    }
}
