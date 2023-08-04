using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var product1 = new Product() { Id = 1, Name = "COROS Apex 46mm", Weight = 30, CategoryId = 1, Price = 2300 };
            var product2 = new Product() { Id = 2, Name = "Garmin Fenix 7", Weight = 40, CategoryId = 1, Price = 4400 };
            var product3 = new Product() { Id = 3, Name = "Garmin Forerunner 945", Weight = 41, CategoryId = 2, Price = 5300 };
            var product4 = new Product() { Id = 4, Name = "COROS Pace 2", Weight = 33, CategoryId = 2, Price = 1820 };

            builder.HasData(product1, product2, product3, product4);
        }
    }
}
