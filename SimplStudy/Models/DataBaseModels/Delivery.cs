namespace SimplStudy.Models.DataBaseModels
{
    public class Delivery
    {
        public int Id { get; set; }

        public DateTime DateOrder { get; set; }

        public DateTime DateReceipt { get; set; }

        public int OfferId { get; set; }

        public Offer? ActiveOffer { get; set; }
    }
}
