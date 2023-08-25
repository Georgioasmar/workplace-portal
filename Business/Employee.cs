using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business
{
    [Table("hrdbEmployeeO")]
    public class Employee
    {
        [Column("employeeID")]
        public int Id { get; set; }

        [Column("employeeName")]
        public string Name { get; set; }

        [Column("employeePhone")]
        public int Phone { get; set; }

        [Column("employeeAddress")]
        public string Address { get; set; }

        [Column("employeeEmail")]
        public string Email { get; set; }

        public Account Acc { get; set; }

        public Job Job { get; set; }

        public Salary Sal { get; set; }
    }

    public class Account
    {
        [Column("employeeUser")]
        public string User { get; set; }

        [Column("employeePass")]
        public string Pass { get; set; }

        [Column("employeeAdmin")]
        public bool isAdmin { get; set; }

        [Column("employeeResetNext")]
        public bool resetNext { get; set; }
    }

    public class Job
    {
        [Column("employeeDep")]
        public string Department { get; set; }

        [Column("employeePos")]
        public string Position { get; set; }

        [Column("employeeFullPos")]
        public string FullPos { get; set; }

        //public decimal GetMinSalary()
        //{
        //    // Assuming you have access to a database context or data source
        //    using (var dbContext = new HrDbContext())
        //    {
        //        var matchingPosition = dbContext.Positions.FirstOrDefault(p => p.PosName == this.Position);
        //        return matchingPosition != null ? matchingPosition.MinSalary : 0;
        //    }
        //}
    }

    public class Salary
    {
        [Column("employeeBasicSal")]
        public decimal Basic { get; set; }

        [Column("employeeTrans")]
        public decimal Trans { get; set; }
    }

    public class HrDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }

        public HrDbContext() : base(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;")
        {
        }
    }

    
}
