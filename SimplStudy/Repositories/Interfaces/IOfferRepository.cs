using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IOfferRepository
    {
        public List<Offer> GetOffers();
        public Task AddOffer(Offer offer);
        public Task UpdateOffer(int ChangebaleOfferId, Offer NewOffer);
        public Task DelOffer(int id);
    }
}
