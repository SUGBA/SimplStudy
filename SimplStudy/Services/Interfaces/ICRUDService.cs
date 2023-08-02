using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface ICRUDService
    {
        public Task AddOffer(Offer offer);
        public List<Offer> GetOffers();
        public List<AddressesPoint> GetAddressesPoints();
        public List<Buyer> GetBuyers();
        public List<Category> GetCategories();
        public List<Delivery> GetDeliveries();
        public List<Manager> GetManagers();
        public List<Product> GetProducts();
        public List<Seller> GetSellers();
        public List<Store> GetStores();
        public Task DelOffer(int id);
        public Task DellOffer(Offer offer);

    }
}
