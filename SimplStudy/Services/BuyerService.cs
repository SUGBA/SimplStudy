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
        public List<Buyer> GetBuyers() => _repository.GetBuyers();
    }
}
