using HotReloadDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotReloadDemo.Controllers
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
            var myDate = new DateOnly(2022, 03, 26);

            var myTime = new TimeOnly(9, 10);

            ViewData["Sample"] = "This is sample Data test for hotreload - hot reload test hello test";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}