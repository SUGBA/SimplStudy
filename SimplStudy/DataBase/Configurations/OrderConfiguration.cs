using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.DataBase.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var order1 = new Order() { Id = 1 };
            var order2 = new Order() { Id = 2 };
            var order3 = new Order() { Id = 3 };

            builder.HasData(order1, order2, order3);
        }
    }
}
