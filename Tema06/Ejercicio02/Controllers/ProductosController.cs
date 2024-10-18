using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio02.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult listadoProductos()
        {
            return View();
        }
    }
}
