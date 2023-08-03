using Microsoft.AspNetCore.Mvc;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class OfferController : Controller
    {
        private readonly IOfferService _offerService;
        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }
        public IActionResult All()
        {
            var result = _offerService.GetOffers();
            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
            return Json(result, options);
        }
        public IActionResult Del(int id)
        {
            _offerService.DellOffer(id);
            return RedirectToAction("All");
        }
        public void Add(Offer offer)
        {
            _offerService.AddOffer(offer);
        }
        public void Update(int ChangebaleOfferId, Offer NewOffer)
        {
            _offerService.UpdateOffer(ChangebaleOfferId, NewOffer);
        }
    }
}
