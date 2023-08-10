using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IDeliveryRepository
    {
        public Task<List<Delivery>> GetDeliveriesAsync();
    }
}
