using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Store_Management_System.Models.ViewModels
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductQTY { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public IFormFile Image { get; set; }
        [Display(Name = "Category ")]
        public string Name { get; set; }
        
        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
       
    }
}
