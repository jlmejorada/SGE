using ENT;
using BL;

namespace Mando.Models.ViewModel
{
    public class ListaMisionesVM: ClsMision
    {
        public List<ClsMision> ListaMisionMV { get; }


        // Constructor
        public ListaMisionesVM()
        {
            ListaMisionMV = ListaMisionBL.listaMisionesBL();
        }

        public ListaMisionesVM(int MisionSelect)
        {
            ListaMisionMV = ListaMisionBL.listaMisionesBL();
            this.Id = MisionSelect;
        }
    }
}
