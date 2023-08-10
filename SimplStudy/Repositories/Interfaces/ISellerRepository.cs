using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface ISellerRepository
    {
        public Task<List<Seller>> GetSellersAsync();
    }
}
