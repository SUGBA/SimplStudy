using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IItemRepository
    {
        public List<Item> GetItems();
    }
}
