using Microsoft.AspNetCore.Mvc;
using SuperPowerAcademy.Models;
//using SuperPowerAcademy.Services;
using System.Diagnostics;

namespace SuperPowerAcademy.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPowerRepository _powerRepository;

        public HomeController(IPowerRepository powerRepository)
        {
            _powerRepository = powerRepository;
        }

       
        public IActionResult Index()
        {
            return View(_powerRepository.GetSuperPower());
        }
         
        [Route("GetHeroesPower")]
        public int GetHeroesPower()
        {
            return _powerRepository.GetSuperPower().HeroesPower;
        }

        [Route("AddHeroesPower/{x}")]
        public int AddHeroesPower(int x)
        {
            return _powerRepository.AddHeroesPower(x).HeroesPower;
            
        }

        [Route("GetVillainsPower")]
        public int GetVillainsPower()
        {
            return _powerRepository.GetSuperPower().VillainsPower;
        }

        [Route("AddVillainsPower/{x}")]
        public int AddVillainsPower(int x)
        {
            return _powerRepository.AddVillainsPower(x).VillainsPower;

        }

    }
}