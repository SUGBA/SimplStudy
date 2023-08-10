using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IDeliveryService
    {
        public Task<List<Delivery>> GetDeliveriesAsync();
    }
}
