using System.ComponentModel.DataAnnotations;

namespace SimplStudy.Models.DataBaseModels
{
    public class AddressesPoint
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///Поле характеризующее адрес пункта выдачи заказов. 
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на менеджеров работающих в конкретном пункте выдачи заказов.
        /// </summary>
        public IEnumerable<Manager> Managers { get; set; } = Array.Empty<Manager>();

        /// <summary>
        /// Навигационные свойство указывающее на магазины, товары которых отправляются из конкретного пункта выдачи заказов.
        /// </summary>
        public IEnumerable<Store> Stores { get; set; } = Array.Empty<Store>();

        /// <summary>
        /// Навигационные свойство указывающее на покупателей, чьи товары будут приходить в конкретном пункте выдачи заказов.
        /// </summary>
        public IEnumerable<Buyer> Buyers { get; set; } = Array.Empty<Buyer>();
    }
}
