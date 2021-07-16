using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Store_Management_System.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Required,StringLength(20),Display(Name ="Job Title")]
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        
        
    }
}
