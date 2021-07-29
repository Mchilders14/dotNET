using System;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreDB_Example.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("server=localhost;database=SalesDbMax;User ID=SA;Password=Bluetruck14;"); // User ID must have a space between.
            }
        }
    }
}
