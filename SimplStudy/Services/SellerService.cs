using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class SellerService : ISellerService
    {
        private readonly ISellerRepository _repository;

        public SellerService(ISellerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Seller>> GetSellersAsync() => await _repository.GetSellersAsync();
    }
}
