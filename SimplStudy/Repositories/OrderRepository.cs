using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using System;

namespace SimplStudy.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;

        public OrderRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        public List<Order> GetOrders() => _context.Orders.ToList();

        public async Task AddOrder(Order order)
        {
            if (order is not null && _context.Orders.FirstOrDefault(x => x.Id == order.Id) is null)
            {
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DelOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order is not null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateOrder(int ChangebaleOrderId, Order NewOrder)
        {
            var ReceivedOffer = _context.Orders.Where(x => x.Id == ChangebaleOrderId).FirstOrDefault();
            if (NewOrder is not null && ReceivedOffer is not null)
            {
                NewOrder.Id = ChangebaleOrderId;
                _context.Entry(ReceivedOffer).CurrentValues.SetValues(NewOrder);

                await _context.SaveChangesAsync();
            }
        }
    }
}
