using Mandaloriano.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mandaloriano.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}