using Microsoft.AspNetCore.Mvc;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class DeliveryController : Controller
    {
        private readonly IDeliveryService _deliveryService;

        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для получения списка описаний доставок товаров.
        /// Ответ отправляется JSON'ом.
        /// Установлен единый формат сериализации json файлов в проекте(см.Program.cs).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            List<Delivery> result = await _deliveryService.GetDeliveriesAsync();
            return Json(result);
        }
    }
}
