using Microsoft.VisualBasic;
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

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для получения списка проданных товаров.
        /// </summary>
        /// <returns> Список проданных товаров</returns>
        public async Task<List<Item>> GetItemsAsync() => await _repository.GetItemsAsync();
    }
}
