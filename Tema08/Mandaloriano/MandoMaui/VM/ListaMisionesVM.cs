using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MandoMaui.VM
{
    internal class ListaMisionesVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public List<ClsMision> listaMisionesVM { get; set; }

        private ClsMision? misionSele;

        public ClsMision? MisionSele
        {
            get => misionSele;
            set
            {
                if (misionSele != value)
                {
                    misionSele = value;
                    OnPropertyChanged("MisionSele");
                }
            }
        }

        public ListaMisionesVM()
        {
            listaMisionesVM = ListaMisionBL.listaMisionesBL();
        }

        public void OnPropertyChanged([CallerMemberName]String nombre="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }


    }
}
