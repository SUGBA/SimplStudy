using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
using SimplStudy.Models.DataBaseDTOModels;
using SimplStudy.Models.DataBaseModels;
using SimplStudy.Services;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для получения списка заказов.
        /// Ответ отправляется JSON'ом.
        /// Установлен единый формат сериализации json файлов в проекте(см.Program.cs).
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> All()
        {
            List<OrderDTO> result = await _orderService.GetOrdersAsync();
            return Json(result);
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для удаления заказа.
        /// После удаления происходит переадресация на список заказов.
        /// </summary>
        /// <param name="Id"> Идентификатор удаляемого элемента </param>
        /// <returns></returns>
        public async Task<IActionResult> Del(int Id)
        {
            await _orderService.DelOrderAsync(Id);
            return RedirectToAction("All");
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для добавления заказа.
        /// После удаления происходит переадресация на список заказов.
        /// </summary>
        /// <param name="NewOrder"> Добавляемый элемент </param>
        /// <returns></returns>
        public async Task<IActionResult> Add(Order NewOrder)
        {
            await _orderService.AddOrderAsync(NewOrder);
            return RedirectToAction("All");
        }

        /// <summary>
        /// Метод, асинхронно обращающийся к соответствующему сервису для замены заказа.
        /// После удаления происходит переадресация на список заказов.
        /// </summary>
        /// <param name="ChangebaleOrderId"> Идентификатор заменяемого элемента </param>
        /// <param name="NewOrder"> Заменяющий экземпляр заказа </param>
        /// <returns></returns>
        public async Task<IActionResult> Update(int ChangebaleOrderId, Order NewOrder)
        {
            await _orderService.UpdateOrderAsync(ChangebaleOrderId, NewOrder);
            return RedirectToAction("All");
        }
    }
}
