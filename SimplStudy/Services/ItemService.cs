using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _repository;

        public ItemService(IItemRepository repository)
        {
            _repository = repository;
        }

        public List<Item> GetItems() => _repository.GetItems();

    }
}
