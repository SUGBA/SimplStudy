using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface ISellerService
    {
        public Task<List<Seller>> GetSellersAsync();
    }
}
