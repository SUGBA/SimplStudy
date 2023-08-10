using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IStoreRepository
    {
        public Task<List<Store>> GetStoresAsync();
    }
}
