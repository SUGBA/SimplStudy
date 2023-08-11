using System.Diagnostics;

namespace SimplStudy.Models.DataBaseModels
{
    public class Store
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Поле характеризующее название магазина. 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на владельца магазина.
        /// </summary>
        public Seller? ActiveSeller { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с владельцами магазинов.
        /// </summary>
        public int SellerId { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на адрес пункта выдачи из которого будут отправляться товары.
        /// </summary>
        public AddressesPoint? ActiveAddressesPoint { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с адресами пунктов выдачи товаров.
        /// </summary>
        public int AddressesPointId { get; set; }
    }
}
