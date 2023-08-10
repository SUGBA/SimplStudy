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

        public IActionResult All()
        {
            var result = _orderService.GetOrders();
            return Json(result);
        }

        public IActionResult Del(int id)
        {
            _orderService.DelOrder(id);
            return RedirectToAction("All");
        }

        public void Add(Order order)
        {
            _orderService.AddOrder(order);
        }

        public void Update(int ChangebaleOrderId, Order NewOrder)
        {
            _orderService.UpdateOrder(ChangebaleOrderId, NewOrder);
        }
    }
}
