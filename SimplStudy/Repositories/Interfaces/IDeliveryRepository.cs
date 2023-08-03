using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IDeliveryRepository
    {
        public List<Delivery> GetDeliveries();
    }
}
