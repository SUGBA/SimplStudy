using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IItemService
    {
        public Task<List<Item>> GetItemsAsync();
    }
}
