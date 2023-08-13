using Microsoft.AspNetCore.Mvc;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для получения списка проданных товаров.
        /// Ответ отправляется JSON'ом.
        /// Установлен единый формат сериализации json файлов в проекте(см.Program.cs).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            List<Item> result = await _itemService.GetItemsAsync();
            return Json(result);
        }
    }
}
