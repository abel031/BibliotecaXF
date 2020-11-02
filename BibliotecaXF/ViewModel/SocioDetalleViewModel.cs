using BibliotecaXF.DAO;
using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.ViewModel
{
    class SocioDetalleViewModel : ViewModelBase
    {
        private Socio _SocioSeleccionado;
        public Socio SocioSeleccionado {
            get { return _SocioSeleccionado; }
            set {
                _SocioSeleccionado = value;
                OnPropertyChanged();
            } 
        }

        public void saveSocio()
        {
            SocioDAO.saveSocio(SocioSeleccionado);
        }

        public void deleteSocio()
        {
            SocioDAO.deleteSocio(SocioSeleccionado);
        }

        public void newSocio()
        {
            SocioSeleccionado = new Socio();
        }
    }
}
