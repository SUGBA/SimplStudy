using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _repository;

        public StoreService(IStoreRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для получения списка интернет-магазинов.
        /// </summary>
        /// <returns> Список интернет-магазинов</returns>
        public async Task<List<Store>> GetStoresAsync() => await _repository.GetStoresAsync();
    }
}
