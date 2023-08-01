using System.Reflection.Metadata.Ecma335;

namespace SimplStudy.Models.DataBaseModels
{
    public class TotalOffer
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public float Surcharge { get; set; }

        public List<Offer>? Offers { get; set; }
    }
}
