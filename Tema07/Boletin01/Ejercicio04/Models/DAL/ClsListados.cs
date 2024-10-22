using Ejercicio04.Models.ENT;

namespace Ejercicio04.Models.DAL
{
    /// <summary>
    /// Listado de clases
    /// </summary>
    public class ClsListados
    {
        /// <summary>
        /// Declaración de la lista
        /// </summary>
        static List<ClsPersona> listaPersonas ;

        /// <summary>
        /// Declaración de la lista
        /// </summary>
        static List<ClsDepartamento> listaDepartamentos;

        /// <summary>
        /// Función que supuestamente saca una lista de personas de una BDD
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> sacarPersonas()
        {

            listaPersonas = new List<ClsPersona> {
                new ClsPersona("Juan", "Pérez", 30, 1),
                new ClsPersona("María", "Gómez", 25, 2),
                new ClsPersona("Carlos", "Rodríguez", 40, 3),
                new ClsPersona("Ana", "Martínez", 35, 4)
            };

            // Recorrer la lista e imprimir la información de cada persona
            return listaPersonas;
        }

        /// <summary>
        /// Función que devuelve a una persona aleatoria
        /// </summary>
        /// <returns></returns>
        public static ClsPersona sacarPersonasRandom()
        { 
            Random ran  = new Random();
            List<ClsPersona> personas = sacarPersonas();
            return personas[ran.Next(personas.Count)];
        }

            /// <summary>
            /// Función que supuestamente saca una lista de departamentos de una BDD
            /// </summary>
            /// <returns></returns>
            public static List<ClsDepartamento> sacarDepartamentos()
        {

            listaDepartamentos = new List<ClsDepartamento> {
                new ClsDepartamento(1, "Recursos Humanos"),
                new ClsDepartamento(2, "Desarrollo"),
                new ClsDepartamento(3, "I+D"),
                new ClsDepartamento(4, "Finanzas")
            };

            // Recorrer la lista e imprimir la información de cada persona
            return listaDepartamentos;
        }

    }
    
}
