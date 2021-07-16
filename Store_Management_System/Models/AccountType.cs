using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Store_Management_System.Models
{
    public class AccountType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
