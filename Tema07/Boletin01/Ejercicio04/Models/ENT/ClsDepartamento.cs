namespace Ejercicio04.Models.ENT
{
    /// <summary>
    /// Clase departamento
    /// </summary>
    public class ClsDepartamento
    {
        /// <summary>
        /// Atributo que almacena la id del departamento
        /// </summary>
        public int IdDepartamento { get; }
        /// <summary>
        /// Atributo que almacena el nombre del departamento
        /// </summary>
	    public String Nombre { get; set; }
        /// <summary>
        /// Constructor del departamento
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <param name="nombre"></param>
        public ClsDepartamento(int idDepartamento, string nombre)
        {
            IdDepartamento = idDepartamento;
            Nombre = nombre;
        }
    }
}
