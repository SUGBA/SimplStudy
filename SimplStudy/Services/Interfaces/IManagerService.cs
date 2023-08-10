using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IManagerService
    {
        public Task<List<Manager>> GetManagersAsync();
    }
}
