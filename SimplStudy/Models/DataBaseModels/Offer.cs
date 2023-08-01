namespace SimplStudy.Models.DataBaseModels
{
    public class Offer
    {
        public int Id { get; set; }
        public int Count { get; set; }

        public int DeliveryId { get; set; }
        public Delivery? ActiveDelivery { get; set; }

        public int SellerId { get; set; }
        public Seller? ActiveSeller { get; set; }

        public int BuyerId { get; set; }
        public Buyer? ActiveBuyer { get; set; }

        public int ProductId { get; set; }
        public Product? ActiveProduct { get; set; }

        public TotalOffer? ActiveTotalOffer { get; set; }
        public int TotalOfferId { get; set; }
    }
}
