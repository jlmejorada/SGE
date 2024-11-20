using ConexionDAL;
using ENT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ScaffoldingASP.Controllers
{
    public class PersonaController : Controller
    {
        // GET: PersonaController
        public ActionResult Index()
        {
            List<ClsPersona> lista = new List<ClsPersona>();
            lista = listadoPersonas.ListaPersonas();
            return View(lista);
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            ClsPersona persona = new ClsPersona();
            //TODO TRYCATCH
            persona = listadoPersonas.BuscaPersona(id);
            return View("Details", persona);
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            ClsPersona persona = new ClsPersona();
            //TODO TRYCATCH
            return View("Create");
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
            ClsPersona persona = new ClsPersona();
            //TODO TRYCATCH
            persona = listadoPersonas.BuscaPersona(id);
            return View("Edit", persona);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            ClsPersona persona = new ClsPersona();
            //TODO TRYCATCH
            persona = listadoPersonas.BuscaPersona(id);
            return View("Delete", persona);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
