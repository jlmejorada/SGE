namespace ENT
{
    public class ClsMision
    {
        #region Atributos

        public int Id { get; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public double Recompensa { get; set; }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public ClsMision() { }

        /// <summary>
        /// Constructor con paramentros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titulo"></param>
        /// <param name="descripcion"></param>
        /// <param name="recompensa"></param>
        public ClsMision(int id, string titulo, string descripcion, double recompensa)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Recompensa = recompensa;
        }

        #endregion
    }
}
