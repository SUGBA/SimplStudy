using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Models.DataBaseDTOModels
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public int TotalPrice { get; set; }

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
