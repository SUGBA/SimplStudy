using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Models.DataBaseDTOModels
{
    public class OrderDTO
    {
        /// <summary>
        /// Первичный ключ.
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

        public OrderDTO() { }

        public OrderDTO(Order order)
        {
            Id = order.Id;
            TotalPrice = order.Items.Sum(x => x.ActiveProduct!.Price);
            TotalCount = order.Items.Sum(x => x.Count);
        }
    }
}
