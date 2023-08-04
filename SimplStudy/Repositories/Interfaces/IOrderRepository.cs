using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public List<Order> GetOrders();

        public Task AddOrder(Order order);

        public Task UpdateOrder(int ChangebaleOrderId, Order NewOrder);

        public Task DelOrder(int id);
    }
}
