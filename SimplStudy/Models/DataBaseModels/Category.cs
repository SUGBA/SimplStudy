namespace SimplStudy.Models.DataBaseModels
{
    public class Category
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Поле характеризующее название категории.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на товары данной категории.
        /// </summary>
        public IEnumerable<Product> Products { get; set; } = Array.Empty<Product>();
    }
}
