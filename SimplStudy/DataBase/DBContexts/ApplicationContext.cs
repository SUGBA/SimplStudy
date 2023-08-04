using Microsoft.EntityFrameworkCore;
using SimplStudy.DataBase.Configurations;
using SimplStudy.Models.DataBaseModels;
using System.Diagnostics;

namespace SimplStudy.DBContexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Offer> Offers { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<AddressesPoint> AddressesPoints { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OfferConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BuyerConfiguration());
            modelBuilder.ApplyConfiguration(new SellerConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new AddressesPointConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryConfiguration());
        }
    }
}
