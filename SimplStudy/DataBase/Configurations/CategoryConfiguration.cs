using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplStudy.Models.DataBaseModels;
using System.Reflection.Emit;

namespace SimplStudy.DataBase.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var category1 = new Category() { Id = 1, Name = "Часы наручные" };
            var category2 = new Category() { Id = 2, Name = "Фотокамеры" };
            var category3 = new Category() { Id = 3, Name = "Процессоры" };

            builder.HasData(category1, category2, category3);
        }
    }
}
