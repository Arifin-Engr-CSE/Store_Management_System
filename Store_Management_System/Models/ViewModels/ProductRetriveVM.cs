using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Store_Management_System.Models.ViewModels
{
    public class ProductRetriveVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductQTY { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string  Image { get; set; }

        [Required,Display(Name ="Category ")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
