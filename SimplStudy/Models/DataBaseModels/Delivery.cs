namespace SimplStudy.Models.DataBaseModels
{
    public class Delivery
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Поле характеризующее дату заказа. 
        /// </summary>
        public DateTime DateOrder { get; set; }

        /// <summary>
        /// Поле характеризующее дату доставки.
        /// </summary>
        public DateTime DateReceipt { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на список купленных товаров.
        /// </summary>
        public IEnumerable<Item> Items { get; set; } = Array.Empty<Item>();
    }
}
