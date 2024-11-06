using Mandaloriano.ENT;
using System.Collections.ObjectModel;

namespace Mandaloriano.Models.DAL
{
    public class ListaMisionDAL
    {
        /// <summary>
        /// Función que devuelve la lista de misiones sacadas de una "BDD"
        /// </summary>
        /// <returns>List<ClsMision></returns>
        public static List<ClsMision> listaMisionesDAL()
        {
            return new List<ClsMision>{
                new ClsMision(1,"Rescate de Baby Yoda","Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.",5000),
                new ClsMision(2,"Recuperar armadura Beskar","Tu armadura de Beskar ha sido robada. Debes encontrarla.",2000),
                new ClsMision(3,"Planeta Sorgon","Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.",500),
                new ClsMision(4,"Renacuajos","Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.",500)
            };
        }
        /// <summary>
        /// Devuelve una mision buscada a traves de su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ClsMision? resMision</returns>
        public static ClsMision unaMisionDAL(int id)
        {
            ClsMision? resMision = new ClsMision();
            List<ClsMision> lista = listaMisionesDAL();
            resMision = lista.Find(mision => mision.Id == id);
            return resMision;
        }
    }
}
