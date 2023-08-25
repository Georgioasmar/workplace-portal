using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Business
{

    [Table("hrdbPosition")]
    public class Position
    {
        [Key]
        [Column("posID")]
        public int posID { get; set; }

        [Column("posName")]
        public string PosName { get; set; }


        [Column("minSalary")]
        public decimal MinSalary { get; set; }

    }

    [Table("hrdbDepartment")]
    public class Department
    {
        [Key]
        [Column("depID")]
        public int depID { get; set; }

        [Column("depName")]
        public string depName { get; set; }

        [Column("depPos")]
        public string depPos { get; set; }

    }

}

[Table("hrdbPosition")]
    public class Position
    {
        [Key]
        [Column("posID")]
        public string posID { get; set; }

        [Column("posName")]
        public string PosName { get; set; }

        [Column("minSalary")]
        public decimal MinSalary { get; set; }

}

[Table("hrdbDepartment")]
public class Department
{
    [Key]
    [Column("depID")]
    public string depID { get; set; }

    [Column("depName")]
    public string depName { get; set; }

    [Column("depPos")]
    public string depPos { get; set; }

}
