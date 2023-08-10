using Microsoft.EntityFrameworkCore;
using SimplStudy.DataBase.Configurations;
using SimplStudy.Models.DataBaseModels;
using System.Diagnostics;

namespace SimplStudy.DBContexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<AddressesPoint> AdressesPoints { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
