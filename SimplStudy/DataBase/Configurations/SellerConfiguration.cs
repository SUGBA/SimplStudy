using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            var seller1 = new Seller() { Id = 1, Name = "Белов Ч.Ч." };
            var seller2 = new Seller() { Id = 2, Name = "Чернов К.Т." };
            var seller3 = new Seller() { Id = 3, Name = "Краснов Х.Т." };
            var seller4 = new Seller() { Id = 4, Name = "Корнев М.М." };

            builder.HasData(seller1, seller2, seller3, seller4);
        }
    }
}
