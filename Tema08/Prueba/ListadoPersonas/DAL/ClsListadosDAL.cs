using Entidades;

namespace DAL
{
    public class ClsListadosDAL
    {
        /// <summary>
        /// Función estatica que devuelve un listado completos de las personas de una BDD
        /// </summary>
        /// <returns>List de ClsPersona</returns>
        public static List<ClsPersona> listadoCompletoPersonasDAL()
        {
            //Declaramos lista de persona
            List<ClsPersona> listaPersonas = new List<ClsPersona>();
            //Creación de una persona y añadirlo en el listado
            ClsPersona miPersona;
            miPersona = new ClsPersona();
            miPersona.Nombre = "Pedro";
            miPersona.Apellidos = "Ramírez";
            miPersona.Edad = 17;
            miPersona.IdDepartamento = 2;
            listaPersonas.Add(miPersona);
            //Creación de una persona y añadirlo en el listado hecho en una sola linea
            listaPersonas.Add(new ClsPersona("Juan", "Marín", 28, 1));
            listaPersonas.Add(new ClsPersona("Ana", "López", 34, 2));
            listaPersonas.Add(new ClsPersona("Carlos", "González", 22, 3));
            listaPersonas.Add(new ClsPersona("Beatriz", "Pérez", 29, 4));
            listaPersonas.Add(new ClsPersona("Luis", "Sánchez", 45, 5));
            listaPersonas.Add(new ClsPersona("María", "Ramírez", 31, 6));
            listaPersonas.Add(new ClsPersona("Pablo", "Torres", 40, 7));
            listaPersonas.Add(new ClsPersona("Lucía", "Vega", 25, 8));
            listaPersonas.Add(new ClsPersona("Diego", "Hernández", 38, 9));
            return listaPersonas;

        }
    }
}
