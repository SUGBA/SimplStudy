using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;
using System.Runtime.InteropServices;

namespace SimplStudy.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository _orderRepository)
        {
            this._orderRepository = _orderRepository;
        }

        public async Task DelOrderAsync(int id)
        {
            await _orderRepository.DelOrder(id);
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _orderRepository.GetOrders();
        }

        public async Task UpdateOrderAsync(int ChangebaleOrderId, Order NewOrder)
        {
            await _orderRepository.UpdateOrder(ChangebaleOrderId, NewOrder);
        }

        public async Task AddOrderAsync(Order order)
        {
            await _orderRepository.AddOrder(order);
        }
    }
}
