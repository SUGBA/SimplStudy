using Microsoft.EntityFrameworkCore;
using SimplStudy.DataBase.Configurations;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace SimplStudy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionsString = builder.Configuration.GetConnectionString("DefaultConnection")!;
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionsString));

            builder.Services.AddControllersWithViews().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                options.JsonSerializerOptions.WriteIndented = true;
            });

            builder.Services.AddTransient<IAddressesPointRepository, AddressesPointRepository>();
            builder.Services.AddTransient<IBuyerRepository, BuyerRepository>();
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            builder.Services.AddTransient<IDeliveryRepository, DeliveryRepository>();
            builder.Services.AddTransient<IManagerRepository, ManagerRepository>();
            builder.Services.AddTransient<IItemRepository, ItemRepository>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<ISellerRepository, SellerRepository>();
            builder.Services.AddTransient<IStoreRepository, StoreRepository>();
            builder.Services.AddTransient<IOrderRepository, OrderRepository>();

            builder.Services.AddTransient<IAddressesPointService, AddressesPointService>();
            builder.Services.AddTransient<IBuyerService, BuyerService>();
            builder.Services.AddTransient<ICategoryService, CategoryService>();
            builder.Services.AddTransient<IDeliveryService, DeliveryService>();
            builder.Services.AddTransient<IManagerService, ManagerService>();
            builder.Services.AddTransient<IItemService, ItemService>();
            builder.Services.AddTransient<IProductService, ProductService>();
            builder.Services.AddTransient<ISellerService, SellerService>();
            builder.Services.AddTransient<IStoreService, StoreService>();
            builder.Services.AddTransient<IOrderService, OrderService>();

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