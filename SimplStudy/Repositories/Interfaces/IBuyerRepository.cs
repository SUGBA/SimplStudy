using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IBuyerRepository
    {
        public Task<List<Buyer>> GetBuyersAsync();
    }
}
