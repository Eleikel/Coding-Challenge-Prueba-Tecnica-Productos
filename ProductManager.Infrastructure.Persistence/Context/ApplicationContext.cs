using Microsoft.EntityFrameworkCore;
using ProductManager.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Infrastructure.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.Entity<OrderItem>()
                .HasOne(o => o.Order)
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            modelBuider.Entity<OrderItem>()
                .HasOne(p => p.Product)
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(p => p.ProductId);

            base.OnModelCreating(modelBuider);
        }
    }
}
