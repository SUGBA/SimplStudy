using SimplStudy.Models.DataBaseModels;
using SimplStudy.Repositories.Interfaces;
using SimplStudy.Services.Interfaces;

namespace SimplStudy.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему репозиторию для получения список категорий товаров.
        /// </summary>
        /// <returns> Список категорий товаров </returns>
        public async Task<List<Category>> GetCategoriesAsync() => await _repository.GetCategoriesAsync();
    }
}
