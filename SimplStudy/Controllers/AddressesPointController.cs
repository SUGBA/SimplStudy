using Microsoft.AspNetCore.Mvc;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class AddressesPointController : Controller
    {
        private readonly IAddressesPointService _addressesPointService;

        public AddressesPointController(IAddressesPointService addressesPointService)
        {
            _addressesPointService = addressesPointService;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для получения списка пунктов выдачи заказов.
        /// Ответ отправляется JSON'ом.
        /// Установлен единый формат сериализации json файлов в проекте(см.Program.cs).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            List<AddressesPoint> result = await _addressesPointService.GetAddressesPointsAsync();
            return Json(result);
        }
    }
}
