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
        public List<Seller> GetSellers() => _context.Sellers.ToList();
    }
}
