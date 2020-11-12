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

        bool nuevo = false;
        public bool saveSocio()
        {
            if (nuevo)
            {
                nuevo = false;
                SocioDAO.addSocio(SocioSeleccionado);
                return true;
            }
            else
            {
                SocioDAO.saveSocio(SocioSeleccionado);
                return false;
            }
        }

        public void deleteSocio()
        {
            SocioDAO.deleteSocio(SocioSeleccionado);
        }

        public void newSocio()
        {
            nuevo = true;
            SocioSeleccionado = new Socio();
        }
    }
}
