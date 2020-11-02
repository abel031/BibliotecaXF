using BibliotecaXF.DAO;
using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.ViewModel
{
    class LibroDetalleViewModel : ViewModelBase
    {
        private Libro _LibroSeleccionado;
        public Libro LibroSeleccionado {
            get { return _LibroSeleccionado; }
            set
            {
                _LibroSeleccionado = value;
                OnPropertyChanged();
            }
        }
        
        public void saveLibro()
        {
            LibroDAO.saveLibro(LibroSeleccionado);
        }

        public void deleteLibro()
        {
            LibroDAO.deleteLibro(LibroSeleccionado);
        }

        public void newLibro()
        {
            LibroSeleccionado = new Libro();
        }

    }
}
