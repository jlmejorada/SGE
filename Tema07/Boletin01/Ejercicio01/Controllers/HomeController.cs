using Ejercicio01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio01.Controllers
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

            DateTime horaActual = DateTime.Now;
            String saludo = "";

            if (horaActual.Hour >= 6 && horaActual.Hour < 12)
            {
                saludo = "buenos dias";

            }
            else if (horaActual.Hour >= 12 && horaActual.Hour < 20)
            {
                saludo = "buenas tardes";

            }
            else if (horaActual.Hour >= 20 && horaActual.Hour < 6)
            {
                saludo = "buenas noches";
            }

            ViewData["saludo"] = saludo;

            return View();
        }

    }

    
}
