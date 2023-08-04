namespace SimplStudy.Models.DataBaseModels
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Price { get; set; }

        public float Weight { get; set; }

        public Category? ActiveCategory { get; set; }

        public int CategoryId { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
