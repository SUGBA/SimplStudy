namespace SimplStudy.Models.DataBaseModels
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int ProductId { get; set; }
        public Product? ActiveProduct { get; set; }
    }
}
