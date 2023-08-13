using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly ApplicationContext _context;

        public ManagerRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        /// <summary>
        /// Метод, асинхронно получающий список менеджеров (работники пунктов выдачи).
        /// </summary>
        /// <returns>Список менеджеров</returns>
        public async Task<List<Manager>> GetManagersAsync() => await _context.Managers.ToListAsync();
    }
}
