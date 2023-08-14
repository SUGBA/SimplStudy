using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseDTOModels;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using System;
using System.Linq;


namespace SimplStudy.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;

        public OrderRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        /// <summary>
        /// Метод, асинхронно получающий список заказов.
        /// Метод, дополнительно подгружает зависимые сущности Items(список купленных товаров),  ActiveProduct(описание купленного товара).
        /// Подгрузка необходима, поскольку на основе зависимых сущностей вычисляются поля TotalPrice, TotalCount, OrderDTO модели.
        /// </summary>
        /// <returns>Список заказов</returns>
        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.Include(x => x.Items).ThenInclude(x => x.ActiveProduct).ToListAsync();
        }

        /// <summary>
        /// Метод, асинхронно добавляющий новый заказ в список заказов.
        /// В первом блоке if, проверяется, что новый заказ отличен от null.
        /// Во втором блоке if, проверяется отсутствие заказа с идентичным идентификатором.
        /// </summary>
        /// <param name="newOrder"> Добавляемый заказ </param>
        /// <returns></returns>
        public async Task AddOrder(Order newOrder)
        {
            if (newOrder is not null)
            {
                var foundOrder = await _context.Orders.FirstOrDefaultAsync(x => x.Id == newOrder.Id);
                if (foundOrder is null)
                {
                    await _context.Orders.AddAsync(newOrder);
                    await _context.SaveChangesAsync();
                }
            }
        }

        /// <summary>
        /// Метод, асинхронно удаляющий заказ из списка заказов.
        /// В первом блоке if, проверяется существования заказа с идентичным идентификатором.
        /// </summary>
        /// <param name="id"> Идентификатор удаляемого заказа </param>
        /// <returns></returns>
        public async Task DelOrder(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order is not null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Метод, заменяющий заказ, новым экземпляром заказа.
        /// В первом блоке if, проверяется что существовует заказ с идентичным идентификатором и что заменяемый заказ не null.
        /// Заменяющему заказу присваивается идентификатор заменяемого заказа.
        /// </summary>
        /// <param name="changebaleOrderId"> Идентификатор заменяемого элемента </param>
        /// <param name="newOrder"> Заменяющий экземпляр заказа </param>
        /// <returns></returns>
        public async Task UpdateOrder(int changebaleOrderId, Order newOrder)
        {
            var receivedOffer = await _context.Orders.Where(x => x.Id == changebaleOrderId).FirstOrDefaultAsync();
            if (newOrder is not null && receivedOffer is not null)
            {
                newOrder.Id = changebaleOrderId;
                _context.Entry(receivedOffer).CurrentValues.SetValues(newOrder);

                await _context.SaveChangesAsync();
            }
        }
    }
}
