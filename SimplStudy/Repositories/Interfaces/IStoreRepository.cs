using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IStoreRepository
    {
        public List<Store> GetStores();
    }
}
