using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IOrderService
    {
        public Task<List<Order>> GetOrdersAsync();

        public Task AddOrderAsync(Order order);

        public Task UpdateOrderAsync(int ChangebaleOrderId, Order NewOrder);

        public Task DelOrderAsync(int id);
    }
}
