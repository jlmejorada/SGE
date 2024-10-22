using Ejercicio04.Models.DAL;
using Ejercicio04.Models.ENT;

namespace Ejercicio04.Models.VM
{
    public class EditarPersonaVM : ClsPersona
    {
        public List<ClsDepartamento> departamentos;

        public EditarPersonaVM(ClsPersona p) : base(p)
        {
            departamentos = ClsListados.sacarDepartamentos();
        }
    }
}
