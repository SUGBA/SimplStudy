namespace SimplStudy.Models.DataBaseModels
{
    public class Delivery
    {
        public int Id { get; set; }

        public DateTime DateOrder { get; set; }

        public DateTime DateReceipt { get; set; }

        public IEnumerable<Item> Items { get; set; } = Array.Empty<Item>();
    }
}
