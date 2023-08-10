using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IAddressesPointService
    {
        public Task<List<AddressesPoint>> GetAddressesPointsAsync();
    }
}
