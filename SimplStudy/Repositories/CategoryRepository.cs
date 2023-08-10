﻿using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;

namespace SimplStudy.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext _context;

        public CategoryRepository(ApplicationContext _context)
        {
            this._context = _context;
        }

        public async Task<List<Category>> GetCategoriesAsync() => await _context.Categories.ToListAsync();
    }
}
