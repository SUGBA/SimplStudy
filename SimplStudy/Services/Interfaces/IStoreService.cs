using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IStoreService
    {
        public Task<List<Store>> GetStoresAsync();
    }
}
