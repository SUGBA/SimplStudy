namespace SimplStudy.Models.DataBaseModels
{
    public class Product
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Поле характеризующее наименование товара. 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Поле характеризующее цену товара. 
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Поле характеризующее вес товара. 
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на тип товара.
        /// </summary>
        public Category? ActiveCategory { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с типа товаров.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на список купленных товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
