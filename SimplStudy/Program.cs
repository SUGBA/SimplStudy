using Microsoft.EntityFrameworkCore;
using SimplStudy.DataBase.Configurations;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services.Interfaces;
using SimplStudy.Services.Realizations;

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

            builder.Services.AddScoped<ICRUDService, CRUDService>();

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

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapGet("/", async (HttpContext context, ApplicationContext db, ICRUDService crudService) =>
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                var offer = new Offer()
                {
                    Deliverys = new List<Delivery>()
                    {
                        new Delivery() { DateOrder = DateTime.UtcNow.AddDays(-2), DateReceipt = DateTime.UtcNow.AddDays(0) }
                    },
                    Buyers = new List<Buyer>()
                    {
                        new Buyer() { Name = "Орлов К.К." }
                    },
                    Products = new List<Product>()
                    {
                        new Product() { Name = "COROS Apex 46mm" }
                    },
                    Sellers = new List<Seller>()
                    {
                        new Seller() { Name = "Чичкин Ч.Ч." }
                     }
                };

                string result1 = string.Join(" | ", crudService.GetProducts().Select(x => x.Name).ToList());
                string of1 = string.Join(" | ", crudService.GetOffers().Select(x => x.Id).ToList());

                await crudService.AddOffer(offer);

                string result2 = string.Join(" | ", crudService.GetProducts().Select(x => x.Name).ToList());
                string of2 = string.Join(" | ", crudService.GetOffers().Select(x => x.Id).ToList());

                await crudService.DellOffer(offer);

                string result3 = string.Join(" | ", crudService.GetProducts().Select(x => x.Name).ToList());
                string of3 = string.Join(" | ", crudService.GetOffers().Select(x => x.Id).ToList());

                await context.Response.WriteAsync(string.Concat(result1, "\n", of1, "\n", result2, "\n", of2, "\n", result3, "\n", of3));
            });

            app.Run();
        }
    }
}