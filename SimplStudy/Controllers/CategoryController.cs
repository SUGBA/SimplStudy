using Microsoft.AspNetCore.Mvc;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для получения списка категорий товаров.
        /// Ответ отправляется JSON'ом.
        /// Установлен единый формат сериализации json файлов в проекте(см.Program.cs).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            List<Category> result = await _categoryService.GetCategoriesAsync();
            return Json(result);
        }
    }
}
