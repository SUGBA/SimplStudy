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
        ///Навигационные свойство указывающее на список купленных товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
