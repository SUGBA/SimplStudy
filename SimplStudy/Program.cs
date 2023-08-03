using Microsoft.EntityFrameworkCore;
using SimplStudy.DataBase.Configurations;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services;
using SimplStudy.Services.Interfaces;

namespace SimplStudy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionsString = builder.Configuration.GetConnectionString("DefaultConnection")!;
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionsString));

            builder.Services.AddControllersWithViews();

            builder.Services.AddTransient<IAddressesPointRepository, AddressesPointRepository>();
            builder.Services.AddTransient<IBuyerRepository, BuyerRepository>();
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            builder.Services.AddTransient<IDeliveryRepository, DeliveryRepository>();
            builder.Services.AddTransient<IManagerRepository, ManagerRepository>();
            builder.Services.AddTransient<IOfferRepository, OfferRepository>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<ISellerRepository, SellerRepository>();
            builder.Services.AddTransient<IStoreRepository, StoreRepository>();

            builder.Services.AddTransient<IAddressesPointService, AddressesPointService>();
            builder.Services.AddTransient<IBuyerService, BuyerService>();
            builder.Services.AddTransient<ICategoryService, CategoryService>();
            builder.Services.AddTransient<IDeliveryService, DeliveryService>();
            builder.Services.AddTransient<IManagerService, ManagerService>();
            builder.Services.AddTransient<IOfferService, OfferService>();
            builder.Services.AddTransient<IProductService, ProductService>();
            builder.Services.AddTransient<ISellerService, SellerService>();
            builder.Services.AddTransient<IStoreService, StoreService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "AllFromStore",
                pattern: "{controller=Store}/{action=All}/{id?}");

            app.Run();
        }
    }
}