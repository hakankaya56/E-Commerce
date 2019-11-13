using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.DataAccess.Concrete.Contexts
{
      public  class NorthwindContext : DbContext
      {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ServerName;Database=DatabaseName;Trusted_Connection=True;");
        }

        //public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }


        public DbSet<Category> Categories { get; set; }
          public DbSet<Customer> Customers { get; set; }
          public DbSet<Order> Orders { get; set; }
          public DbSet<OrderDetail> OrderDetails { get; set; }
          public DbSet<Product> Products { get; set; }

    }
}
