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

            var seller1 = new Seller() { Id = 1, Name = "Белов Ч.Ч.", OfferId = 1 };
            var seller2 = new Seller() { Id = 2, Name = "Чернов К.Т.", OfferId = 2 };
            var seller3 = new Seller() { Id = 3, Name = "Краснов Х.Т.", OfferId = 3 };
            var seller4 = new Seller() { Id = 4, Name = "Корнев М.М.", OfferId = 3 };

            builder.HasData(seller1, seller2, seller3, seller4);
        }
    }
}
