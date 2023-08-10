﻿using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly ApplicationContext _context;

        public StoreRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        public async Task<List<Store>> GetStoresAsync() => await _context.Stores.ToListAsync();
    }
}
