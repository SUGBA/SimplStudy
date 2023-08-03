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
            var product1 = new Product() { Id = 1, Name = "COROS Apex 46mm", OfferId = 1 };
            var product2 = new Product() { Id = 2, Name = "Garmin Fenix 7", OfferId = 2 };
            var product3 = new Product() { Id = 3, Name = "Garmin Forerunner 945", OfferId = 3 };
            var product4 = new Product() { Id = 4, Name = "COROS Pace 2", OfferId = 4 };
            var product5 = new Product() { Id = 5, Name = "Garmin vívoactive 4", OfferId = 5 };
            var product6 = new Product() { Id = 6, Name = "Garmin Instinct 2 Solar", OfferId = 6 };
            var product7 = new Product() { Id = 7, Name = "Suunto 9 Peak", OfferId = 7 };
            var product8 = new Product() { Id = 8, Name = "Polar Grit X", OfferId = 8 };
            var product9 = new Product() { Id = 9, Name = "Garmin Forerunner 55", OfferId = 8 };

            builder.HasData(product1,
                            product2,
                            product3,
                            product4,
                            product5,
                            product6,
                            product7,
                            product8,
                            product9);
        }
    }
}
