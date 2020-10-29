using System;
using System.Collections.Generic;
using BibliotecaXF.Model;

namespace BibliotecaXF.Helpers
{
    class BD
    {
        public static List<Socio> Socios = new List<Socio>();
        public static List<Libro> Libros = new List<Libro>();
        public static List<Prestamo> Prestamos = new List<Prestamo>();


        static BD()
        {
            Socios.Add(new Socio { DNI = "111", Nombre = "Pepe" });
            Socios.Add(new Socio { DNI = "222", Nombre = "Julia" });

            Libros.Add(new Libro { Titulo = "Fanta", Genero = "Fantasia", ISBN = "111" });
            Libros.Add(new Libro { Titulo = "Terro", Genero = "Terror", ISBN = "222" });


        }

        public static void saveSocio(Socio s)
        {
            Socios.Add(s);
        }
        public static void deleteSocio(Socio s)
        {
            Socios.Remove(s);
        }
    }
}
