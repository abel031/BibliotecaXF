using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BibliotecaXF.ViewModel
{
    class ListaSociosViewModel : ViewModelBase
    {
        public ObservableCollection<Socio> Socios { get; set; }

        public ListaSociosViewModel()
        {
            Socios = new ObservableCollection<Socio>(BD.Socios);
        }

    }
}
