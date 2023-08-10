using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly ApplicationContext _context;

        public BuyerRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        public async Task<List<Buyer>> GetBuyersAsync() => await _context.Buyers.ToListAsync();
    }
}
