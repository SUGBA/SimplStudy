using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class AddressesPointConfiguration : IEntityTypeConfiguration<AddressesPoint>
    {
        public void Configure(EntityTypeBuilder<AddressesPoint> builder)
        {
            var address1 = new AddressesPoint() { Id = 1, Address = "Ленина, 32" };
            var address2 = new AddressesPoint() { Id = 2, Address = "Уссурийская, 47" };
            var address3 = new AddressesPoint() { Id = 3, Address = "Братская, 55" };
            var address4 = new AddressesPoint() { Id = 4, Address = "Петровсеая, 32" };

            builder.HasData(address1, address2, address3, address4);
        }
    }
}
