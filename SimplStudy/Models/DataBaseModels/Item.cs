namespace SimplStudy.Models.DataBaseModels
{
    public class Item
    {
        /// <summary>
        /// Поле характеризующее количество купленных экземпляров товара. 
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на тип доставки товара.
        /// </summary>
        public Delivery? ActiveDelivery { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с доставкой товара.
        /// </summary>
        public int DeliveryId { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на продавца товара товара.
        /// </summary>
        public Seller? ActiveSeller { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с продавцами товаров.
        /// </summary>
        public int SellerId { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на описание товара.
        /// </summary>
        public Product? ActiveProduct { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с описаниями товаров.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на заказ.
        /// </summary>
        public Order? ActiveOrder { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с заказами.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Навигационные свойство указывающее на покупателя.
        /// </summary>
        public Buyer? ActiveBuyer { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с покупателями.
        /// </summary>
        public int BuyerId { get; set; }
    }
}
