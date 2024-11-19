using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDAL
{
    public class listadoPersonas
    {

        /// <summary>
        /// Crea una lista de Personas y se conecta a la BDD para devolvela llena
        /// </summary>
        /// <returns> List<ClsPersona> </returns>
        public static List<ClsPersona> ListaPersonas()
        {
            SqlConnection miConexion = new SqlConnection();

            List<ClsPersona> listadoPersonas = new List<ClsPersona>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            ClsPersona oPersona;

            miConexion.ConnectionString = CLSConexion.CadenaDeConexion();

            try

            {

                miConexion.Open();


                miComando.CommandText = "SELECT * FROM personas";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();


                if (miLector.HasRows)

                {

                    while (miLector.Read())

                    {
                        //Nombre, Apellidos, Telefono, Direccion, Foto, FechaNacimiento, IDDepartamento
                        oPersona = new ClsPersona();

                        oPersona.Id = (int)miLector["ID"];

                        oPersona.Nombre = (string)miLector["Nombre"];

                        oPersona.Apellidos = (string)miLector["Apellidos"];

                        if (miLector["FechaNacimiento"] != System.DBNull.Value)

                        { oPersona.FechaNacimiento = (DateTime)miLector["FechaNacimiento"]; }

                        oPersona.Direccion = (string)miLector["Direccion"];

                        oPersona.Telefono = (string)miLector["Telefono"];

                        oPersona.IDDepartamento = (int)miLector["IDDepartamento"];

                        listadoPersonas.Add(oPersona);

                    }

                }

                miLector.Close();

                miConexion.Close();

            }

            catch (SqlException exSql)

            {

                throw exSql;

            }

            return listadoPersonas;

        }
    }
}
