namespace SimplStudy.Models.DataBaseModels
{
    public class Buyer
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int AdressesPointId { get; set; }
        public AdressesPoint? Address { get; set; }

        public Offer? ActiveOffer { get; set; }
        public int OfferId { get; set; }
    }
}
