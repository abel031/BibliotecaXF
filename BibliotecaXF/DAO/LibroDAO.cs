using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.DAO
{
    class LibroDAO
    {
        public static void saveLibro(Libro l)
        {
            var pos = BD.Libros.IndexOf(l);
            if (pos >= 0)
            {
                BD.Libros[pos] = l;
            }
            else
            {
                BD.Libros.Add(l);
            }
        }

        public static void deleteLibro(Libro l)
        {
            BD.Libros.Remove(l);
        }

        /*public static void addLibro(Libro l)
        {
            BD.Libros.Add(l);
        }*/
    }
}
