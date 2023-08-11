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

        public async Task<IActionResult> All()
        {
            List<OrderDTO> result = await _orderService.GetOrdersAsync();
            return Json(result);
        }

        public async Task<IActionResult> Del(int id)
        {
            await _orderService.DelOrderAsync(id);
            return RedirectToAction("All");
        }

        public async Task Add(Order order)
        {
            await _orderService.AddOrderAsync(order);
        }

        public async Task Update(int ChangebaleOrderId, Order NewOrder)
        {
            await _orderService.UpdateOrderAsync(ChangebaleOrderId, NewOrder);
        }
    }
}
