namespace SimplStudy.Models.DataBaseModels
{
    public class Seller
    {
        public int Id { get; set; }
       
        public string? Name { get; set; }

        public Store? ActiveStore { get; set; }

        public Offer? ActiveOffer { get; set; }
        
        public int OfferId { get; set; }
    }
}
