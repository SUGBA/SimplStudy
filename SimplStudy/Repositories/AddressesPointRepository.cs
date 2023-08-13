using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class AddressesPointRepository : IAddressesPointRepository
    {
        private readonly ApplicationContext _context;

        public AddressesPointRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        /// <summary>
        /// Метод, асинхронно получающий список пунктов выдачи товаров.
        /// </summary>
        /// <returns>Список пунктов выдачи товаров</returns>
        public async Task<List<AddressesPoint>> GetAddressesPointsAsync() => await _context.AdressesPoints.ToListAsync();
    }
}
