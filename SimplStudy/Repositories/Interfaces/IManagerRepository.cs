using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IManagerRepository
    {
        public Task<List<Manager>> GetManagersAsync();
    }
}
