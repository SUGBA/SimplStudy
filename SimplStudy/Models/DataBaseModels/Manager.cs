namespace SimplStudy.Models.DataBaseModels
{
    public class Manager
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Поле характеризующее ФИО менеджера в пункте выдачи. 
        /// </summary>
        public int HoursProduction { get; set; }

        /// <summary>
        /// Поле характеризующее выработку в часах конкретного менеджера. 
        /// </summary>
        public AddressesPoint? ActiveAddressesPoint { get; set; }

        /// <summary>
        /// Внешний ключ на таблицу с адресами пунктов выдачи товаров.
        /// </summary>
        public int AddressesPointId { get; set; }
    }
}
