using Microsoft.AspNetCore.Mvc;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class SellerController : Controller
    {
        private readonly ISellerService _sellerService;

        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для получения списка продавцов.
        /// Ответ отправляется JSON'ом.
        /// Установлен единый формат сериализации json файлов в проекте(см.Program.cs).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            List<Seller> result = await _sellerService.GetSellersAsync();
            return Json(result);
        }
    }
}
