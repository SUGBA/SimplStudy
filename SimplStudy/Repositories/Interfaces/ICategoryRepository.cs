using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
    }
}
