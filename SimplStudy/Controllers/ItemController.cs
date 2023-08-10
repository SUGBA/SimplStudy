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
        
        [HttpGet]
        public IActionResult All()
        {
            var result = _itemService.GetItems();
            return Json(result);
        }
    }
}
