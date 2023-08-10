using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
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

        public async Task<List<Order>> GetOrders()
        {
            //var result = _context.Orders.Include(x => x.Items).ThenInclude(x => x.ActiveProduct).ToList();
            var result = await _context.Orders.ToListAsync();
            return result;
        }

        public async Task AddOrder(Order order)
        {
            if (order is not null)
            {
                var foundOrder = await _context.Orders.FirstOrDefaultAsync(x => x.Id == order.Id);
                if (foundOrder is null)
                {
                    await _context.Orders.AddAsync(order);
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task DelOrder(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order is not null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateOrder(int ChangebaleOrderId, Order NewOrder)
        {
            var ReceivedOffer = await _context.Orders.Where(x => x.Id == ChangebaleOrderId).FirstOrDefaultAsync();
            if (NewOrder is not null && ReceivedOffer is not null)
            {
                NewOrder.Id = ChangebaleOrderId;
                _context.Entry(ReceivedOffer).CurrentValues.SetValues(NewOrder);

                await _context.SaveChangesAsync();
            }
        }
    }
}
