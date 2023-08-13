using SimplStudy.Models.DataBaseDTOModels;
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

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для удаления заказа с идентичным идентификатором.
        /// </summary>
        /// <param name="id"> Идентификатор удаляемого элемента </param>
        /// <returns></returns>
        public async Task DelOrderAsync(int id)
        {
            await _orderRepository.DelOrder(id);
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для получения списка заказов.
        /// Из списка заказов формируется список DTO заказов.
        /// В конструкторе DTO модели, вычисляются поля TotalPrice и TotalCount на основе зависимых сущностей, подруженных ранее.
        /// </summary>
        /// <returns> Список DTO заказов</returns>
        public async Task<List<OrderDTO>> GetOrdersAsync()
        {
            var orders = await _orderRepository.GetOrders();
            return orders.Select(x => new OrderDTO(x)).ToList();
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для обновления заказа с идентичным идентификатором.
        /// </summary>
        /// <param name="ChangebaleOrderId"> Идентификатор заменяемого элемента </param>
        /// <param name="NewOrder"> Заменяющий экземпляр заказа </param>
        /// <returns></returns>
        public async Task UpdateOrderAsync(int ChangebaleOrderId, Order NewOrder)
        {
            await _orderRepository.UpdateOrder(ChangebaleOrderId, NewOrder);
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для добавления заказа.
        /// </summary>
        /// <param name="order"> Добавляемый заказ </param>
        /// <returns></returns>
        public async Task AddOrderAsync(Order order)
        {
            await _orderRepository.AddOrder(order);
        }
    }
}
