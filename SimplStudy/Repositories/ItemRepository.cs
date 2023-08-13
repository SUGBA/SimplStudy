using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationContext _context;

        public ItemRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        /// <summary>
        /// Метод, асинхронно получающий список купленных товаров (из купленных товаров потом формируются заказы).
        /// </summary>
        /// <returns>Список купленных товаров</returns>
        public async Task<List<Item>> GetItemsAsync() => await _context.Items.ToListAsync();
    }
}
