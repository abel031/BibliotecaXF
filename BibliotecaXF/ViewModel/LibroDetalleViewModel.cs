using BibliotecaXF.DAO;
using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.ViewModel
{
    class LibroDetalleViewModel
    {
        public Libro LibroSeleccionado { get; set; }
        
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
