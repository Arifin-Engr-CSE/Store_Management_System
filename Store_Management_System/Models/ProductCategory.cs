using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Store_Management_System.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }
        [Required,StringLength(20),Display(Name="Product Category ")]
        public string Name { get; set; }
    }
}
