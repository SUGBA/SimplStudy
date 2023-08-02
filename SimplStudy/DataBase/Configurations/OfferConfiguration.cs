using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            var offer1 = new Offer() { Id = 1 };
            var offer2 = new Offer() { Id = 2 };
            var offer3 = new Offer() { Id = 3 };
            var offer4 = new Offer() { Id = 4 };
            var offer5 = new Offer() { Id = 5 };
            var offer6 = new Offer() { Id = 6 };
            var offer7 = new Offer() { Id = 7 };
            var offer8 = new Offer() { Id = 8 };

            builder.HasData(offer1, offer2, offer3, offer4,
                            offer5, offer6, offer7, offer8);
        }
    }
}
