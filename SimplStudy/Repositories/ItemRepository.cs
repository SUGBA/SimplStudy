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

        public List<Item> GetItems() => _context.Items.ToList();
    }
}
