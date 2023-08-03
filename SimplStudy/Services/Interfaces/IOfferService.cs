using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IOfferService
    {
        public Task AddOffer(Offer offer);

        public List<Offer> GetOffers();

        public Task DellOffer(int id);

        public Task UpdateOffer(int ChangebaleOfferId, Offer NewOffer);
    }
}
