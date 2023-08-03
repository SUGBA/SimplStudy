using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _repository;
        public OfferService(IOfferRepository repository)
        {
            _repository = repository;
        }
        public Task AddOffer(Offer offer) => _repository.AddOffer(offer);
        public List<Offer> GetOffers() => _repository.GetOffers();
        public Task DellOffer(int id) => _repository.DelOffer(id);
        public Task UpdateOffer(int ChangebaleOfferId, Offer NewOffer)
            => _repository.UpdateOffer(ChangebaleOfferId, NewOffer);
    }
}
