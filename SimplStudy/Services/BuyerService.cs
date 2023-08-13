using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerRepository _repository;

        public BuyerService(IBuyerRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для получения список покупателей.
        /// </summary>
        /// <returns> Список категорий покупателей </returns>
        public async Task<List<Buyer>> GetBuyersAsync() => await _repository.GetBuyersAsync();
    }
}
