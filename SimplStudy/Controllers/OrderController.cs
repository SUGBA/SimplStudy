using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimplStudy.DBContexts;
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

        private readonly ApplicationContext _context;

        public OrderController(IOrderService orderService, ApplicationContext context)
        {
            _orderService = orderService;
            _context = context;
        }

        public async Task<IActionResult> All()
        {
            List<Order> result = await _orderService.GetOrdersAsync();
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
