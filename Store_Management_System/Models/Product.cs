using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store_Management_System.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductQTY { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        [Display(Name = "Branch")]
        public int BranchId { get; set; }

        [ForeignKey("ProductCategory")]
        public int CategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductPhoto ProductPhoto { get; set; }
    }

    public class ProductPhoto
    {
        [Required ,Key,ForeignKey("Product")]
        public int ProductId { get; set; }
        public string Image { get; set; }
        public virtual Product Product { get; set; }
    }
}
