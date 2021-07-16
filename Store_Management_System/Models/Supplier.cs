using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Store_Management_System.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required, StringLength(20), Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required, StringLength(20), Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
