namespace SimplStudy.Models.DataBaseModels
{
    public class Offer
    {
        public int Id { get; set; }

        public List<Delivery>? Deliverys { get; set; }

        public List<Seller>? Sellers { get; set; }

        public List<Buyer>? Buyers { get; set; }

        public List<Product>? Products { get; set; }

    }
}
