namespace SimplStudy.Models.DataBaseModels
{
    public class Seller
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Поле характеризующее ФИО продавца. 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на магазины по этому адресу.
        /// </summary>
        public IEnumerable<Store> Stores { get; set; } = Array.Empty<Store>();

        /// <summary>
        /// Навигационные свойство указывающее на список проданных товаров.
        /// </summary>
        public IEnumerable<Item> Items { get; set; } = Array.Empty<Item>();
    }
}
