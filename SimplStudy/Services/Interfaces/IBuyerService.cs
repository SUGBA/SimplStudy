using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IBuyerService
    {
        public Task<List<Buyer>> GetBuyersAsync();
    }
}
