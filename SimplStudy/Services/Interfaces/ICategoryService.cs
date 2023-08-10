using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetCategoriesAsync();
    }
}
