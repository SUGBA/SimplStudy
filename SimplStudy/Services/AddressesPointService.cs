using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class AddressesPointService : IAddressesPointService
    {
        private readonly IAddressesPointRepository _repository;

        public AddressesPointService(IAddressesPointRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AddressesPoint>> GetAddressesPointsAsync() => await _repository.GetAddressesPointsAsync();
    }
}
