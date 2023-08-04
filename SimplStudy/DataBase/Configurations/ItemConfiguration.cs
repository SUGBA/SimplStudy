using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            var item1 = new Item() { BuyerId = 1, DeliveryId = 1, ProductId = 1, SellerId = 1, OrderId = 1, Count = 2 };
            var item2 = new Item() { BuyerId = 1, DeliveryId = 2, ProductId = 2, SellerId = 1, OrderId = 1, Count = 2 };
            var item3 = new Item() { BuyerId = 2, DeliveryId = 1, ProductId = 3, SellerId = 1, OrderId = 2, Count = 3 };
            var item4 = new Item() { BuyerId = 2, DeliveryId = 1, ProductId = 4, SellerId = 2, OrderId = 2, Count = 4 };
            var item5 = new Item() { BuyerId = 3, DeliveryId = 2, ProductId = 3, SellerId = 2, OrderId = 3 , Count = 1 };
            var item6 = new Item() { BuyerId = 3, DeliveryId = 2, ProductId = 2, SellerId = 2, OrderId = 3 , Count = 1 };
            var item7 = new Item() { BuyerId = 3, DeliveryId = 3, ProductId = 3, SellerId = 3, OrderId = 3 , Count = 1 };
            var item8 = new Item() { BuyerId = 3, DeliveryId = 4, ProductId = 4, SellerId = 4, OrderId = 3 , Count = 2 };

            builder.HasData(item1, item2, item3, item4, item5, item6, item7, item8);
        }
    }
}
