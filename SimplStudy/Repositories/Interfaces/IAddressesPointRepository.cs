using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IAddressesPointRepository
    {
        public Task<List<AddressesPoint>> GetAddressesPointsAsync();
    }
}
