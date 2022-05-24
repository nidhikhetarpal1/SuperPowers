using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using Villains.Services;

namespace Villains.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBaseService _baseService;
        private readonly IConfiguration _config;



        public HomeController(ILogger<HomeController> logger, IBaseService baseService, IConfiguration config)
        {
            _logger = logger;
            _baseService = baseService;
            _config = config;
        }

        public async Task<IActionResult> Index()
        {
            int count = await _baseService.SendRequestAsync(HttpMethod.Get, _config["SuperPowerAcademyUrl"] + "GetVillainsPower");

            return View(count);
        }

        [HttpPost]
        public async Task<IActionResult> Increment(int x = 5)
        {

            await _baseService.SendRequestAsync(HttpMethod.Post, _config["SuperPowerAcademyUrl"] + "AddVillainsPower/" + x);
            return RedirectToAction("Index");
        }
    }
}