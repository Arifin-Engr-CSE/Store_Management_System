using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Models
{
    public class SalesItem
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
