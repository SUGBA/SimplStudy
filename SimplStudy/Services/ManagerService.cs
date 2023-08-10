using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _repository;

        public ManagerService(IManagerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Manager>> GetManagersAsync() => await _repository.GetManagersAsync();
    }
}
