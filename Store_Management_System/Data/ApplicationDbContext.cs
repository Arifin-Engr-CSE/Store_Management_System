using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser>applicationUsers { get; set; }
        public DbSet<AccountType> accountTypes { get; set; }
        public DbSet<Employer> employers { get; set; }
        public DbSet<Manager> managers { get; set; }
        public DbSet<Job> jobs { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<CustomerPhoto> customerPhotos { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductPhoto> productPhotos { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<SalesItem> salesItems { get; set; }




    }
}
