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
            BD.saveLibro(LibroSeleccionado);
        }

        public void deleteLibro()
        {
            BD.deleteLibro(LibroSeleccionado);
        }

        public void newLibro()
        {
            BD.addLibro(LibroSeleccionado);
        }

    }
}
