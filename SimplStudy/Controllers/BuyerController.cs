using Microsoft.AspNetCore.Mvc;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class BuyerController : Controller
    {
        private readonly IBuyerService _buyerService;
        
        public BuyerController(IBuyerService buyerService)
        {
            _buyerService = buyerService;
        }
        
        [HttpGet]
        public IActionResult All()
        {
            var result = _buyerService.GetBuyers();
            return Json(result);
        }
    }
}
