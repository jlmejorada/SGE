using ConexionDAL;
using Ej01Maui.VM.Utils;
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
        #endregion

        #region PROPIEDADES
        public CLSConexion Conexion { get { return conexion; } set { conexion = value; } }
        public String Respuesta { get { return respuesta; } set { respuesta = value; } }
        public DelegateCommand PulsaBotonCommand { get { return pulsaBotonCommand; } }
        #endregion

        #region Constructores
        public VistaConexion() 
        {
            pulsaBotonCommand = new DelegateCommand(pulsaBotonCommand_Execute);
        }
        #endregion


        #region COMMANDS
        private void pulsaBotonCommand_Execute()
        {
            SqlConnection miConexion = new SqlConnection();

            miConexion.ConnectionString = CLSConexion.CadenaDeConexion();
            miConexion.Open();

            respuesta = miConexion.State.ToString();
            OnPropertyChanged("Respuesta");

        }
        #endregion



     }
}
