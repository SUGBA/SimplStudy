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
            builder.HasKey(e => new { e.ProductId, e.BuyerId, e.SellerId, e.DeliveryId });
            builder.HasOne(x => x.ActiveDelivery)
                   .WithMany(y => y.Items)
                   .HasForeignKey(x => x.DeliveryId);
            builder.HasOne(x => x.ActiveSeller)
                   .WithMany(y => y.Items)
                   .HasForeignKey(x => x.SellerId);
            builder.HasOne(x => x.ActiveProduct)
                   .WithMany(y => y.Items)
                   .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.ActiveBuyer)
                   .WithMany(y => y.Items)
                   .HasForeignKey(x => x.BuyerId);
        }
    }
}
