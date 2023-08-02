using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            var store1 = new Store() { Id = 1, Name = "Shop1", SellerId = 1 };
            var store2 = new Store() { Id = 2, Name = "Shop2", SellerId = 2 };
            var store3 = new Store() { Id = 3, Name = "Shop3", SellerId = 3 };
            var store4 = new Store() { Id = 4, Name = "Shop4", SellerId = 4 };

            builder.HasData(store1, store2, store3, store4);
        }
    }
}
