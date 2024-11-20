using Microsoft.AspNetCore.Mvc;
using ScaffoldingASP.Models;
using System.Diagnostics;

namespace ScaffoldingASP.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
