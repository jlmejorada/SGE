using DAL;
using Entidades;

namespace BL
{
    public class ClsListadosBL
    {
        /// <summary>
        /// Función estatica que llama a la DAL, aplica las reglas de negocio oportunas y 
        /// devuelve un lista de personas.
        /// </summary>
        /// <returns>List de ClsPersona</returns>
        public static List<ClsPersona> listadoPersonasBL()
        {
            List<ClsPersona> miListado = ClsListadosDAL.listadoCompletoPersonasDAL();

            //TODO Comprobar si es jueves y antes o no de las 13:30
                

            return miListado;

        }
    }
}
