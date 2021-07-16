using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Store_Management_System.Models
{
    public class ApplicationUser
    {
        [Key]
        public int UserID { get; set; }
        [Required,StringLength(20),Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(20), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, StringLength(20), Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required, StringLength(20), Display(Name = "Password")]
        public string Password { get; set; }
        [Required, StringLength(20), Display(Name = "Email")]
        public string Email { get; set; }
        [Required, StringLength(20), Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public List<AccountType> AccountTypes { get; set; }
    }
}
