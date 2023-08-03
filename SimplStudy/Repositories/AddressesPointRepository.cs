using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class AddressesPointRepository : IAddressesPointRepository
    {
        private readonly ApplicationContext _context;

        public AddressesPointRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        public List<AddressesPoint> GetAddressesPoints() => _context.AddressesPoints.ToList();
    }
}
