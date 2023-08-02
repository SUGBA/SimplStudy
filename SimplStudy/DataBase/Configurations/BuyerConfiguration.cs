using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class BuyerConfiguration : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            var buyer1 = new Buyer() { Id = 1, Name = "Орлов К.Ч.", OfferId = 1 };
            var buyer2 = new Buyer() { Id = 2, Name = "Шмелев С.С.", OfferId = 2 };
            var buyer3 = new Buyer() { Id = 3, Name = "Синичкин К.П.", OfferId = 3 };
            var buyer4 = new Buyer() { Id = 4, Name = "Ястребов А.А.", OfferId = 4 };
            var buyer5 = new Buyer() { Id = 5, Name = "Курков П.П.", OfferId = 5 };

            builder.HasData(buyer1, buyer2, buyer3, buyer4, buyer5);
        }
    }
}
