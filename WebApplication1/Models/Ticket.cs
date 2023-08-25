using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Models
{
    [Table("hrdbHelp")]
    public class Ticket
    {
        [Key]
        [Column("ticketID")]
        public int Id { get; set; }

        [Column("SenderID")]
        public int senderID { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Description")]
        public string Desc { get; set; }

        [Column("ticketDep")]
        public string Dep { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("Statement")]
        public string Statement { get; set; }

        [Column("Priority")]
        public int Priority { get; set; }

        [Column("Type")]
        public string Type { get; set; }

        [Column("Issue")]
        public string Issue { get; set; }

        [Column("OwnerID")]
        public string OwnerID { get; set; }

    }

    [Table("hrdbProblem")]
    public class Problem
    {
        [Key]
        [Column("ProblemID")]
        public int Id { get; set; }

        [Column("ProblemIssue")]
        public string Issue { get; set; }

        [Column("ProblemType")]
        public string Type { get; set; }

        [Column("Fix")]
        public string Fix{ get; set; }
    }
}
