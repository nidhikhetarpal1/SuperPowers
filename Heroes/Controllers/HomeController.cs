
using Heroes.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Heroes.Controllers
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
            int heroesCount = await _baseService.SendRequestAsync(HttpMethod.Get,_config["SuperPowerAcademyUrl"]+"GetHeroesPower");
            
            return View(heroesCount);
        }

        [HttpPost]
        public async Task<IActionResult> Increment(int x=5)
        {

            await _baseService.SendRequestAsync(HttpMethod.Post,_config["SuperPowerAcademyUrl"] + "AddHeroesPower/"+x);
            return RedirectToAction("Index");
        }

    }
}