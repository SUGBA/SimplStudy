namespace SimplStudy.Models.DataBaseModels
{
    public class Seller
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<Store> Stores { get; set; } = new List<Store>();

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
