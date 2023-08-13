using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class SellerRepository : ISellerRepository
    {
        private readonly ApplicationContext _context;

        public SellerRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        /// <summary>
        /// Метод, асинхронно получающий список продавцов (владельцы магазинов).
        /// </summary>
        /// <returns>Список продавцов</returns>
        public async Task<List<Seller>> GetSellersAsync() => await _context.Sellers.ToListAsync();
    }
}
