﻿using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ApplicationContext _context;

        public DeliveryRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        /// <summary>
        /// Метод, асинхронно получающий список описаний доставок товаров.
        /// </summary>
        /// <returns>Список доставок</returns>
        public async Task<List<Delivery>> GetDeliveriesAsync() => await _context.Deliveries.ToListAsync();
    }
}
