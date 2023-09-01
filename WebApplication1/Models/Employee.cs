using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;



namespace Business.Models
{
    [Table("hrdbEmployeeO")]
    public class Employee
    {
        [Key]
        [Column("employeeID")]
        public int Id { get; set; }

        [Column("employeeName")]
        public string Name { get; set; }

        [Column("employeeUser")] // Account User column
        public string User { get; set; }

        [Column("employeePass")] // Account Pass column
        public string Pass { get; set; }

        [Column("employeePhone")]
        public string Phone { get; set; }

        [Column("employeeAddress")]
        public string Address { get; set; }

        [Column("employeeEmail")]
        public string Email { get; set; }

        [Column("employeeAdmin")]
        public bool isAdmin { get; set; }

        [Column("employeeResetNext")]
        public bool resetNext { get; set; }

        [Column("employeeDep")]
        public string Dep { get; set; }

        [Column("employeePos")]
        public string Pos { get; set; }

        [Column("employeeFullPos")]
        public string FullPos { get; set; }

        //public Account Acc { get; set; }

        //[NotMapped]
        //public Job Job { get; set; }

        [Column("employeeBasicSal")]
        public decimal Basic { get; set; }

        [Column("employeeTrans")]
        public decimal Trans { get; set; }

        //[NotMapped]
        //public Salary Sal { get; set; }
    }

    public class HrDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }

        public HrDbContext(DbContextOptions<HrDbContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Job>().HasNoKey(); // Set Job class as keyless
        //    modelBuilder.Entity<Salary>().HasNoKey(); // Set Salary class as keyless


        //    base.OnModelCreating(modelBuilder);
        //}

    }

    //public class Account
    //{
    //    [Key]
    //    [Column("employeeUser")]
    //    public string User { get; set; }

    //    [Column("employeePass")]
    //    public string Pass { get; set; }

    //    [Column("employeeAdmin")]
    //    public bool isAdmin { get; set; }

    //    [Column("employeeResetNext")]
    //    public bool resetNext { get; set; }
    //}

    //public class Job
    //{
    //    [Column("employeeDep")]
    //    public string Department { get; set; }

    //    [Column("employeePos")]
    //    public string Position { get; set; }

    //    [Column("employeeFullPos")]
    //    public string FullPos { get; set; }

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

    //public class Salary
    //{
    //    [Column("employeeBasicSal")]
    //    public decimal Basic { get; set; }

    //    [Column("employeeTrans")]
    //    public decimal Trans { get; set; }
    //}



    //public class HrDbContext : DbContext
    //{
    //    public DbSet<Employee> Employees { get; set; }
    //    //public DbSet<Position> Positions { get; set; }
    //    //public DbSet<Department> Departments { get; set; }

    //    public HrDbContext(DbContextOptions<HrDbContext> options) : base(options)
    //    {
    //    }

    //    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    //{
    //    //    //modelBuilder.Entity<Job>().HasNoKey(); // Set Job class as keyless
    //    //    modelBuilder.Entity<Salary>().HasNoKey(); // Set Salary class as keyless


    //    //    base.OnModelCreating(modelBuilder);
    //    //}

    //}
