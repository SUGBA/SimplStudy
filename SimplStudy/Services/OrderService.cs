using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository _orderRepository)
        {
            this._orderRepository = _orderRepository;
        }

        public void DelOrder(int id)
        {
            _orderRepository.DelOrder(id);
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public void UpdateOrder(int ChangebaleOrderId, Order NewOrder)
        {
            _orderRepository.UpdateOrder(ChangebaleOrderId, NewOrder);
        }

        public void AddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }
    }
}
