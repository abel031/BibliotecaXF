using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Controlador
{
    class PrestamoController
    {
        public static void doPrestamo(Socio s, Libro l)
        {
            BD.Prestamos.Add(new Prestamo { libro = l, socio = s });
            s.Prestamos.Add(l);
            l.Prestado = true;
        }

        public static void delPrestamo(Socio socio, Libro libro)
        {
            foreach (Prestamo p in BD.Prestamos)
            {
                if(p.libro.ISBN==libro.ISBN && p.socio.DNI == socio.DNI)
                {
                    BD.Prestamos.Remove(p);
                    socio.Prestamos.Remove(libro);
                    libro.Prestado = false;
                    break;
                }
            }
        }
    }
}
