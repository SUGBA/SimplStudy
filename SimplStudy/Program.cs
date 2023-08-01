using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;

namespace SimplStudy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionsString = builder.Configuration.GetConnectionString("DefaultConnection")!;
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionsString));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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

            app.MapGet("/", async (HttpContext context, ApplicationContext db) =>
            {
                var offers = db.Offers.Include(x => x.ActiveProduct).Select(x => x.ActiveProduct!.Name).ToList();
                await context.Response.WriteAsync(string.Join("\n", offers));
            });

            app.Run();
        }
    }
}