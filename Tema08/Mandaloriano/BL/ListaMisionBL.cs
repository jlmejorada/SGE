using DAL;
using ENT;
using System.Runtime.CompilerServices;

namespace BL
{
    public class ListaMisionBL
    {
        /// <summary>
        /// En nuestras politicas de empresa, tenemos que no se mostraran los datos despues de las 12 de la noche hasta las 8 de la mañana. Si se puede mostrar, llama a lista misionesDAL
        /// </summary>
        /// <returns>List<ClsMision></returns>
        public static List<ClsMision> listaMisionesBL()
        {
            List<ClsMision> lista = new List<ClsMision>();

            if (DateTime.Now.Hour > 8 )
            {
               lista = DAL.ListaMisionDAL.listaMisionesDAL();
            }

            return lista;
        }

        /// <summary>
        /// En nuestras politicas de empresa, tenemos que se mostraran los datos. Si se puede mostrar, llama a unaMisionDAL pasandole un id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ClsMision</returns>
        public static ClsMision unaMisionBL(int id)
        {
            ClsMision miMision = new ClsMision();

            miMision = DAL.ListaMisionDAL.unaMisionDAL(id);

            return miMision;
        }
    }
}
