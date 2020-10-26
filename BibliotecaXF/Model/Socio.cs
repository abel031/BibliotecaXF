using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.Model
{
    public class Socio
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public List<Libro> prestamos { get; set; } = new List<Libro>();

    }
}
