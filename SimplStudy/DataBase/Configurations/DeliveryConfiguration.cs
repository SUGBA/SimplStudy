using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            var delivery1 = new Delivery()
            {
                Id = 1,
                DateOrder = DateTime.UtcNow.AddDays(-2),
                DateReceipt = DateTime.UtcNow.AddDays(0),
                OfferId = 1
            };
            var delivery2 = new Delivery()
            {
                Id = 2,
                DateOrder = DateTime.UtcNow.AddDays(-3),
                DateReceipt = DateTime.UtcNow.AddDays(0),
                OfferId = 2
            };
            var delivery3 = new Delivery()
            {
                Id = 3,
                DateOrder = DateTime.UtcNow.AddDays(-4),
                DateReceipt = DateTime.UtcNow.AddDays(1),
                OfferId = 3
            };
            var delivery4 = new Delivery()
            {
                Id = 4,
                DateOrder = DateTime.UtcNow.AddDays(-5),
                DateReceipt = DateTime.UtcNow.AddDays(2),
                OfferId = 4
            };

            builder.HasData(delivery1, delivery2, delivery3, delivery4);
        }
    }
}
