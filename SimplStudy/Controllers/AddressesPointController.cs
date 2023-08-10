using Microsoft.AspNetCore.Mvc;
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
        
        [HttpGet]
        public IActionResult All()
        {
            var result = _addressesPointService.GetAddressesPoints();
            return Json(result);
        }
    }
}
