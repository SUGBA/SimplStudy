namespace SimplStudy.Models.DataBaseModels
{
    public class Buyer
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Поле характеризующее ФИО покупателя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на адрес, в который будет производится доставка товара.
        /// </summary>
        public AddressesPoint? ActiveAddressesPoint { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с адресами пунктов выдачи товаров.
        /// </summary>
        public int AddressesPointId { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на список купленных товаров.
        /// </summary>
        public IEnumerable<Item> Items { get; set; } = Array.Empty<Item>();
    }
}
