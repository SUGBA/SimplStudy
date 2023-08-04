namespace SimplStudy.Models.DataBaseModels
{
    public class Buyer
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public AddressesPoint? ActiveAddressesPoint { get; set; }

        public int AddressesPointId { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
