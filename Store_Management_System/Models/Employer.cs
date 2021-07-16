using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store_Management_System.Models
{
    public class Employer
    {
        [Key]
        public int EmployerId { get; set; }
        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(20), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, StringLength(20), Display(Name = "Email")]
        public string Email { get; set; }
        [Required, StringLength(20), Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public DateTime HiredDate { get; set; }
        [ForeignKey("Job")]
        public int JobId { get; set; }
        public Job job { get; set; }

    }
}
