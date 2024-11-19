using ConexionDAL;
using Ej01Maui.VM.Utils;
using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01Maui.VM
{
    internal class VistaConexion: clsVMBase
    {
        #region ATRIBUTOS
        private CLSConexion conexion;
        private String respuesta = "";
        private DelegateCommand pulsaBotonCommand;
        private List<ClsPersona> lista;
        #endregion

        #region PROPIEDADES
        public CLSConexion Conexion { get { return conexion; } set { conexion = value; } }
        public String Respuesta { get { return respuesta; } set { respuesta = value; } }
        public DelegateCommand PulsaBotonCommand { get { return pulsaBotonCommand; } }
        public List<ClsPersona> Lista { get { return lista;  } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// La vista viene construida a traves de la ejecución del comando de pulsaBoton
        /// </summary>
        public VistaConexion() 
        {
            pulsaBotonCommand = new DelegateCommand(pulsaBotonCommand_Execute);
        }
        #endregion

        #region COMMANDS
        /// <summary>
        /// Realiza una conexión con el servidor y registra el estado de esta. Tambien saca una lista de contactos de la bdd
        /// </summary>
        private void pulsaBotonCommand_Execute()
        {
            SqlConnection miConexion = new SqlConnection();

            try
<<<<<<< Updated upstream
            {
                miConexion.ConnectionString = CLSConexion.CadenaDeConexion();
                miConexion.Open();

                respuesta = miConexion.State.ToString();
                OnPropertyChanged("Respuesta");
=======

            {
                miConexion = new SqlConnection();

                miConexion.ConnectionString = CLSConexion.CadenaDeConexion();
                miConexion.Open();

                respuesta = miConexion.State.ToString();
                OnPropertyChanged("Respuesta");


            }
            catch (Exception ex)
            {
                respuesta = "Hubo un problema";
                OnPropertyChanged("Respuesta");
            }
            finally
            {
                miConexion.Close();
            }
>>>>>>> Stashed changes

                lista = listadoPersonas.ListaPersonas();
                OnPropertyChanged("Lista");
            }
            catch
            {
                respuesta = "Ha ocurrido un problema";
                OnPropertyChanged("Respuesta");
            }
            finally {

                miConexion.Close();
            }
        }
        #endregion

    }
}
