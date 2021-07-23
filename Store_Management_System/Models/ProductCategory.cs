using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Store_Management_System.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new List<Product>();
        }

        [Key]
        public int CategoryId { get; set; }
        [ Display(Name = "Category ")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
