using System.ComponentModel.DataAnnotations.Schema;

namespace SimplStudy.Models.DataBaseModels
{
    public class Order
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Поле характеризующее общую стоимость всех товаров в заказе. 
        /// </summary>
        public int TotalPrice { get; set; }

        /// <summary>
        ///  Поле характеризующее общее количество всех товаров в заказе. 
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        ///Навигационные свойство указывающее на список купленных товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
