using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWeb.Models;

namespace MyWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products_Capacity>().HasKey(pc => new
            {
                pc.Capacity_Id,
                pc.Sku_Code
            });

            modelBuilder.Entity<Products_Capacity>().HasOne(c => c.Capacity).WithMany(pc => pc.Products_Capacities).HasForeignKey(c => c.Capacity_Id);

            modelBuilder.Entity<Products_Capacity>().HasOne(c => c.Products).WithMany(pc => pc.Products_Capacities).HasForeignKey(c => c.Sku_Code);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Capacity> Capacities { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Products_Capacity> Products_Capacities { get; set; }

        //orders related tables 
        public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}