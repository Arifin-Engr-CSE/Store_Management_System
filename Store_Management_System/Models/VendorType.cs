﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Models
{
    public class VendorType
    {
        public int VendorTypeId { get; set; }
        [Required]
        public string VendorTypeName { get; set; }
        public string Description { get; set; }
    }
}
