namespace SimplStudy.Models.DataBaseModels
{
    public class Seller
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public IEnumerable<Store> Stores { get; set; } = Array.Empty<Store>();

        public IEnumerable<Item> Items { get; set; } = Array.Empty<Item>();
    }
}
