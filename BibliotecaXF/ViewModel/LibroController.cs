using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Controlador
{
    class LibroController
    {
        public static Libro GetLibro(string isbn)
        {
            foreach (Libro l in BD.Libros)
            {
                if (l.ISBN == isbn) return l;
            }
            return null;
        }
    }
}
