using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoPersonasMAUI.ViewModels
{
    internal class MainPageVM
    {
        private List<ClsPersona> lista;

        public List<ClsPersona> Lista { get {
                lista = ClsListadosBL.listadoPersonasBL();
                
                return lista; } }

    }
}
