using BibliotecaXF.DAO;
using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BibliotecaXF.ViewModel
{
    public class SocioViewModel : ViewModelBase
    {
        private Socio _SocioSeleccionado;
        public Socio SocioSeleccionado
        {
            get { return _SocioSeleccionado; }
            set
            {
                _SocioSeleccionado = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Socio> _Socios =new  ObservableCollection<Socio>(BD.Socios);
        public ObservableCollection<Socio> Socios {
            get { return _Socios; }
            set
            {
                _Socios = value;
                OnPropertyChanged();
            }
        }

        private Boolean nou = false;


        public void saveSocio()
        {
            if (nou)
            {
                Socios.Add(SocioSeleccionado);
            }
            else
            {
                var pos = Socios.IndexOf(SocioSeleccionado);
                Socios[pos] = SocioSeleccionado;
                OnPropertyChanged("Socios");
            }
            SocioDAO.saveSocio(SocioSeleccionado);
        }

        public void deleteSocio()
        {
            Socios.Remove(SocioSeleccionado);
            SocioDAO.deleteSocio(SocioSeleccionado);
        }

        public void newSocio()
        {
            SocioSeleccionado = new Socio();
            nou = true;
        }


    }
}
