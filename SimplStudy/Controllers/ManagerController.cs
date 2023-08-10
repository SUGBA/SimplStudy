using Microsoft.AspNetCore.Mvc;
using SimplStudy.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SimplStudy.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IManagerService _managerService;
        
        public ManagerController(IManagerService managerService)
        {
            _managerService = managerService;
        }
        
        [HttpGet]
        public IActionResult All()
        {
            var result = _managerService.GetManagers();
            return Json(result);
        }
    }
}
