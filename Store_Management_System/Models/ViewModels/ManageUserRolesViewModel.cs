using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Models.ViewModels
{
    public class ManageUserRolesViewModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool Selected { get; set; }
    }
}
