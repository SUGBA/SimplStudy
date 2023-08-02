using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services.Realizations
{
    public class CRUDService : ICRUDService
    {
        private readonly ApplicationContext _context;

        public CRUDService(ApplicationContext context)
        {
            _context = context;
        }

        #region Create      
        /*
         * Спросить нужно ли добавлять возможность добавления отдельных связей
         * Например, добавить отдельно продавца у которого по факту не будет заполнено поле с OfferId
         */

        public async Task AddOffer(Offer offer)
        {
            await _context.Offers.AddAsync(offer);
            await _context.SaveChangesAsync();
        }

        #endregion

        #region Read
        public List<Offer> GetOffers() => _context.Offers.AsNoTracking().ToList();
        public List<AddressesPoint> GetAddressesPoints() => _context.AdressesPoints.ToList();
        public List<Buyer> GetBuyers() => _context.Buyers.ToList();
        public List<Category> GetCategories() => _context.Categorys.ToList();
        public List<Delivery> GetDeliveries() => _context.Deliverys.ToList();
        public List<Manager> GetManagers() => _context.Managers.ToList();
        public List<Product> GetProducts() => _context.Products.AsNoTracking().ToList();
        public List<Seller> GetSellers() => _context.Sellers.ToList();
        public List<Store> GetStores() => _context.Stores.ToList();
        #endregion

        #region Update
        /*
         * Спросить как именно реалиховывать изменения (по id или еще каким способ)
         */
        #endregion

        #region Delete
        public async Task DelOffer(int id)
        {
            var offer = _context.Offers.FirstOrDefault(o => o.Id == id);
            if (offer is not null)
            {
                _context.Offers.Remove(offer);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DellOffer(Offer offer)
        {
            if (offer is not null)
            {
                _context.Offers.Remove(offer);
                await _context.SaveChangesAsync();
            }
        }
        #endregion
    }
}
