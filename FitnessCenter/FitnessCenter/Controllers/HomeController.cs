using System.Diagnostics;
using FitnessCenter.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // ABOUT Sayfasını açan metod
        public IActionResult About()
        {
            return View();
        }

        // RANDEVU Sayfasını açan metod (Fiyat planını parametre olarak alır)
        [HttpGet]
        public IActionResult Appointment(string plan)
        {
            // Seçilen planı (Basic, Standard vs.) sayfaya taşıyoruz
            ViewBag.SelectedPlan = plan;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
