using Ej01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace Ej01.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index2()
        {
            String estado = "";
            SqlConnection miConexion = new SqlConnection();

            try
            {
                string cadenaDeConexion = DataBaseDAL.CadenaDeConexion();
                miConexion.ConnectionString = cadenaDeConexion;
                miConexion.Open();
                estado = miConexion.State.ToString();

            } catch (Exception ex) {
                estado = "Hubo un error";
            }
            ViewBag.Conexion = estado;
            return View("Index");
        }
    }
}
