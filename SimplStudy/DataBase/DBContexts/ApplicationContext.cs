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

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                        .HasKey(e => new { e.ProductId, e.BuyerId, e.SellerId, e.DeliveryId });
            modelBuilder.Entity<Item>()
                        .HasOne(x => x.ActiveDelivery)
                        .WithMany(y => y.Items)
                        .HasForeignKey(x => x.DeliveryId);
            modelBuilder.Entity<Item>()
                        .HasOne(x => x.ActiveSeller)
                        .WithMany(y => y.Items)
                        .HasForeignKey(x => x.SellerId);
            modelBuilder.Entity<Item>()
                        .HasOne(x => x.ActiveProduct)
                        .WithMany(y => y.Items)
                        .HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<Item>()
                        .HasOne(x => x.ActiveBuyer)
                        .WithMany(y => y.Items)
                        .HasForeignKey(x => x.BuyerId);

            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
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
