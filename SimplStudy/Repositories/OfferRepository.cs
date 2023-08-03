using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly ApplicationContext _context;

        public OfferRepository(ApplicationContext _context)
        {
            this._context = _context;
        }
        public List<Offer> GetOffers() => _context.Offers.ToList();
        public async Task AddOffer(Offer offer)
        {
            if (offer is not null && _context.Offers.FirstOrDefault(x => x.Id == offer.Id) is null)
            {
                await _context.Offers.AddAsync(offer);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateOffer(int ChangebaleOfferId, Offer NewOffer)
        {
            var ReceivedOffer = _context.Offers.Where(x => x.Id == ChangebaleOfferId).FirstOrDefault();
            if (NewOffer is not null && ReceivedOffer is not null)
            {
                await DelOffer(ChangebaleOfferId);
                NewOffer.Id = ChangebaleOfferId;
                await AddOffer(NewOffer);

                await _context.SaveChangesAsync();
            }
        }
        public async Task DelOffer(int id)
        {
            var offer = _context.Offers.FirstOrDefault(o => o.Id == id);
            if (offer is not null)
            {
                _context.Offers.Remove(offer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
