using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            var manager1 = new Manager()
            {
                Id = 1,
                HoursProduction = 120,
                Name = "Петров А.А.",
                AddressesPointId = 1
            };
            var manager2 = new Manager()
            {
                Id = 2,
                HoursProduction = 220,
                Name = "Сидоров А.Б.",
                AddressesPointId = 2
            };
            var manager3 = new Manager()
            {
                Id = 3,
                HoursProduction = 50,
                Name = "Репин Б.В.",
                AddressesPointId = 3
            };

            builder.HasData(manager1, manager2, manager3);
        }
    }
}
