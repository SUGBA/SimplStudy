namespace SimplStudy.Models.DataBaseModels
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public float Weight { get; set; }

        public int CategoryId { get; set; }
        public Category? ActiveCategory { get; set; }

        public Offer? ActiveOffer { get; set; }
        public int OfferId { get; set; }
    }
}
