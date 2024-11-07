using BL;
using Mando.Models;
using Mando.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mando.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ListaMisionesVM vm = new ListaMisionesVM();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(int MisionSelect)
        {
            ListaMisionesVM vm = new ListaMisionesVM(MisionSelect);
            ENT.ClsMision selecc = ListaMisionBL.unaMisionBL(MisionSelect, vm.ListaMisionMV);
            return View(vm);
        }
    }
}
