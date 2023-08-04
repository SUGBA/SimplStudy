using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IOrderService
    {
        public List<Order> GetOrders();

        public void AddOrder(Order order);

        public void UpdateOrder(int ChangebaleOrderId, Order NewOrder);

        public void DelOrder(int id);
    }
}
