using Microsoft.EntityFrameworkCore;
using SimplStudy.Models.DataBaseModels;
using System.Diagnostics;

namespace SimplStudy.DBContexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Delivery> Deliverys { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<AddressesPoint> AdressesPoints { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var totalOffer1 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer2 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer3 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer4 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer5 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer6 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer7 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer8 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer9 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer10 = new TotalOffer() { Price = 2500, Surcharge = 250 };
            var totalOffer11 = new TotalOffer() { Price = 2500, Surcharge = 250 };

            var category1 = new Category() { Name = "Часы наручные" };
            var category2 = new Category() { Name = "Фотокамеры" };
            var category3 = new Category() { Name = "Процессоры" };

            modelBuilder.Entity<Category>().HasData(category1, category2, category3);

            var product1 = new Product() { Name = "COROS Apex 46mm", ActiveCategory = category1 };
            var product2 = new Product() { Name = "Garmin Fenix 7", ActiveCategory = category1 };
            var product3 = new Product() { Name = "Garmin Forerunner 945", ActiveCategory = category1 };
            var product4 = new Product() { Name = "COROS Pace 2", ActiveCategory = category2 };
            var product5 = new Product() { Name = "Garmin vívoactive 4", ActiveCategory = category2 };
            var product6 = new Product() { Name = "Garmin Instinct 2 Solar", ActiveCategory = category2 };
            var product7 = new Product() { Name = "Suunto 9 Peak", ActiveCategory = category3 };
            var product8 = new Product() { Name = "Polar Grit X", ActiveCategory = category3 };
            var product9 = new Product() { Name = "Garmin Forerunner 55", ActiveCategory = category3 };

            modelBuilder.Entity<Product>().HasData(product1, product2, product3,
                                                    product4, product5, product6,
                                                    product7, product8, product9);

            var manager1 = new Manager() { HoursProduction = 120, Name = "Петров А.А." };
            var manager2 = new Manager() { HoursProduction = 220, Name = "Сидоров А.Б." };
            var manager3 = new Manager() { HoursProduction = 50, Name = "Репин Б.В." };

            modelBuilder.Entity<Manager>().HasData(manager1, manager2, manager3);

            var address1 = new AddressesPoint() { Address = "Ленина, 32", ActiveManager = manager1 };
            var address2 = new AddressesPoint() { Address = "Уссурийская, 47", ActiveManager = manager2 };
            var address3 = new AddressesPoint() { Address = "Братская, 55", ActiveManager = manager3 };


            modelBuilder.Entity<AddressesPoint>().HasData(address1, address2, address3);

            var buyer1 = new Buyer() { Name = "Орлов К.Ч.", Address = address1 };
            var buyer2 = new Buyer() { Name = "Шмелев С.С.", Address = address1 };
            var buyer3 = new Buyer() { Name = "Синичкин К.П.", Address = address2 };
            var buyer4 = new Buyer() { Name = "Ястребов А.А.", Address = address2 };
            var buyer5 = new Buyer() { Name = "Курков П.П.", Address = address3 };

            modelBuilder.Entity<Buyer>().HasData(buyer1, buyer2, buyer3, buyer4, buyer5);

            var store1 = new Store() { Name = "Shop1", Address = address3 };
            var store2 = new Store() { Name = "Shop2", Address = address3 };
            var store3 = new Store() { Name = "Shop3", Address = address2 };
            var store4 = new Store() { Name = "Shop4", Address = address1 };

            modelBuilder.Entity<Store>().HasData(store1, store2, store3, store4);

            var seller1 = new Seller() { Name = "Белов Ч.Ч.", ActiveStore = store1 };
            var seller2 = new Seller() { Name = "Чернов К.Т.", ActiveStore = store2 };
            var seller3 = new Seller() { Name = "Краснов Х.Т.", ActiveStore = store3 };
            var seller4 = new Seller() { Name = "Корнев М.М.", ActiveStore = store4 };

            modelBuilder.Entity<Seller>().HasData(seller1, seller2, seller3, seller4);

            var delivery1 = new Delivery() { DateOrder = DateTime.Now.AddDays(-2), DateReceipt = DateTime.Now.AddDays(0) };
            var delivery2 = new Delivery() { DateOrder = DateTime.Now.AddDays(-3), DateReceipt = DateTime.Now.AddDays(0) };
            var delivery3 = new Delivery() { DateOrder = DateTime.Now.AddDays(-4), DateReceipt = DateTime.Now.AddDays(1) };
            var delivery4 = new Delivery() { DateOrder = DateTime.Now.AddDays(-5), DateReceipt = DateTime.Now.AddDays(2) };

            modelBuilder.Entity<Delivery>().HasData(delivery1, delivery2, delivery3, delivery4);

            var offer1 = new Offer() { ActiveDelivery = delivery1, ActiveSeller = seller1, ActiveBuyer = buyer1, ActiveProduct = product1, ActiveTotalOffer = totalOffer1 };
            var offer2 = new Offer() { ActiveDelivery = delivery2, ActiveSeller = seller2, ActiveBuyer = buyer2, ActiveProduct = product2, ActiveTotalOffer = totalOffer2 };
            var offer3 = new Offer() { ActiveDelivery = delivery3, ActiveSeller = seller3, ActiveBuyer = buyer3, ActiveProduct = product3, ActiveTotalOffer = totalOffer3 };
            var offer4 = new Offer() { ActiveDelivery = delivery4, ActiveSeller = seller4, ActiveBuyer = buyer4, ActiveProduct = product4, ActiveTotalOffer = totalOffer4 };
            var offer5 = new Offer() { ActiveDelivery = delivery1, ActiveSeller = seller1, ActiveBuyer = buyer1, ActiveProduct = product5, ActiveTotalOffer = totalOffer5 };
            var offer6 = new Offer() { ActiveDelivery = delivery2, ActiveSeller = seller2, ActiveBuyer = buyer2, ActiveProduct = product6, ActiveTotalOffer = totalOffer6 };
            var offer7 = new Offer() { ActiveDelivery = delivery2, ActiveSeller = seller3, ActiveBuyer = buyer3, ActiveProduct = product6, ActiveTotalOffer = totalOffer7 };
            var offer8 = new Offer() { ActiveDelivery = delivery3, ActiveSeller = seller3, ActiveBuyer = buyer4, ActiveProduct = product7, ActiveTotalOffer = totalOffer8 };
            var offer9 = new Offer() { ActiveDelivery = delivery4, ActiveSeller = seller2, ActiveBuyer = buyer1, ActiveProduct = product8, ActiveTotalOffer = totalOffer9 };
            var offer10 = new Offer() { ActiveDelivery = delivery1, ActiveSeller = seller1, ActiveBuyer = buyer1, ActiveProduct = product9, ActiveTotalOffer = totalOffer10 };
            var offer11 = new Offer() { ActiveDelivery = delivery4, ActiveSeller = seller1, ActiveBuyer = buyer2, ActiveProduct = product9, ActiveTotalOffer = totalOffer11 };

            modelBuilder.Entity<Offer>().HasData(offer1, offer2, offer3, offer4, offer5, offer6, offer7, offer8, offer9, offer10, offer11);
        }
    }
}
