using Microsoft.AspNetCore.Mvc;
using Pruebas.Models;
using System.Diagnostics;

namespace Pruebas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public String Index()
        {
            return "Hola Mundo";
        }

        public String Coco()
        {
            return "SuperCrocks";
        }

        public int Entero()
        {
            return 8;
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
