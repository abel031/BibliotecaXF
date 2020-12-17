using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaXF.ViewModel
{
    class ListaSociosViewModel : ViewModelBase
    {
        private ObservableCollection<Socio> _Socios { get; set; }
        public ObservableCollection<Socio> Socios
        {
            get { return _Socios; }
            set
            {
                _Socios = value;
                OnPropertyChanged();
            }
        }

        public ListaSociosViewModel()
        {
            //Socios = new ObservableCollection<Socio>(BD.Socios);
            Task<List<Socio>> tsocio = Providers.socioDAO.AllSociosAsync();
            Socios = new ObservableCollection<Socio>(tsocio.Result);
        }

        public void AddSocio(Socio s)
        {
            Socios.Add(s);
        }

        public void DeleteSocio(Socio s)
        {
            Socios.Remove(s);
        }

        public void ModifySocio(Socio s)
        {
            var pos = Socios.IndexOf(s);
            Socios[pos] = s;
        }

    }
}
