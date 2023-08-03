using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IManagerRepository
    {
        public List<Manager> GetManagers();
    }
}
