namespace SimplStudy.Models.DataBaseModels
{
    public class Store
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Seller? ActiveSeller { get; set; }

        public int SellerId { get; set; }

        public AddressesPoint? Address { get; set; }
    }
}
