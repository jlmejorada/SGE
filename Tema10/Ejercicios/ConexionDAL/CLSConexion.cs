namespace ConexionDAL
{
    public class CLSConexion
    {
        /// <summary>
        /// Devuelve la cadena de conexion
        /// </summary>
        /// <returns>String cadena</returns>
        public static String CadenaDeConexion()
        {
            String cadena = "server=jlmejorada.database.windows.net;" +
                    "database=jlmejoradaBD;uid=usuario;" +
                    "pwd=LaCampana123;trustServerCertificate=true;";

            return cadena;
        }
    }
}
