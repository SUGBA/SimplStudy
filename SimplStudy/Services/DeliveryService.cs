using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepository _repository;

        public DeliveryService(IDeliveryRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для получения списка описаний доставок.
        /// </summary>
        /// <returns> Список описаний доставок</returns>
        public async Task<List<Delivery>> GetDeliveriesAsync() => await _repository.GetDeliveriesAsync();
    }
}
