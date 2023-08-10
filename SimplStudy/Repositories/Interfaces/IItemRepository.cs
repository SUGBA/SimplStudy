using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IItemRepository
    {
        public Task<List<Item>> GetItemsAsync();
    }
}
