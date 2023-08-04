using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ApplicationContext _context;

        public DeliveryRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        public List<Delivery> GetDeliveries() => _context.Deliveries.ToList();
    }
}
