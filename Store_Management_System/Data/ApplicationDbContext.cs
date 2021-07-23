using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store_Management_System.Models;

namespace Store_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }

        public DbSet<Store_Management_System.Models.Bill> Bills { get; set; }

        public DbSet<Store_Management_System.Models.BillType> BillTypes { get; set; }

        public DbSet<Store_Management_System.Models.Branch> Branchs { get; set; }

        public DbSet<Store_Management_System.Models.Customer> Customers { get; set; }

        public DbSet<Store_Management_System.Models.CustomerType> CustomerTypes { get; set; }

        public DbSet<Store_Management_System.Models.GoodsReceivedNote> GoodsReceivedNotes { get; set; }


        public DbSet<Store_Management_System.Models.Product> Products { get; set; }

        public DbSet<Store_Management_System.Models.ProductCategory> ProductTypes { get; set; }
        public DbSet<Store_Management_System.Models.ProductPhoto> ProductPhotos { get; set; }

        public DbSet<Store_Management_System.Models.PurchaseOrder> PurchaseOrders { get; set; }

        public DbSet<Store_Management_System.Models.PurchaseOrderLine> PurchaseOrderLines { get; set; }

        public DbSet<Store_Management_System.Models.PurchaseType> PurchaseTypes { get; set; }

        public DbSet<Store_Management_System.Models.SalesOrder> SalesOrders { get; set; }

        public DbSet<Store_Management_System.Models.SalesOrderLine> SalesOrderLines { get; set; }

        public DbSet<Store_Management_System.Models.SalesType> SalesTypes { get; set; }

        public DbSet<Store_Management_System.Models.Vendor> Vendors { get; set; }

        public DbSet<Store_Management_System.Models.VendorType> VendorTypes { get; set; }
    }
}
