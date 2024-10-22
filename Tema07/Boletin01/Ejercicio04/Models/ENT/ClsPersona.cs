namespace Ejercicio04.Models.ENT
{
    /// <summary>
    /// Clase persona
    /// </summary>
    public class ClsPersona
    {
        /// <summary>
        /// Atributo que almacena el nombre de la persona
        /// </summary>
        public String Nombre { get; set; }

        /// <summary>
        /// Atributo que almacena los apellidos de la persona
        /// </summary>
        public String Apellidos { get; set; }

        /// <summary>
        /// Atributo que almacena la edad de la persona
        /// </summary>
        public int Edad { get; set; }

        /// <summary>
        /// Atributo que almacena el id del departamento donde trabaja la persona
        /// </summary>
        public int IdDepartamento { get; set; }

        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="edad"></param>
        /// <param name="idDepartamento"></param>
        public ClsPersona(string nombre, string apellidos, int edad, int idDepartamento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            IdDepartamento = idDepartamento;
        }

        /// <summary>
        /// Constructor con un  propio objeto persona
        /// </summary>
        /// <param name="p"></param>
        public ClsPersona(ClsPersona p)
        {
            Nombre = p.Nombre;
            Apellidos = p.Apellidos;
            Edad = p.Edad;
            IdDepartamento = p.IdDepartamento;
        }
    }
}
