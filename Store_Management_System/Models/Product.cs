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
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public List<ProductCategory> productCategories { get; set; }
        public List<Supplier>suppliers { get; set; }

    }
    public class ProductPhoto
    {
        [Key, ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string ProductImage { get; set; }
    }
}
