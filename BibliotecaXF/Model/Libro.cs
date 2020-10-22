using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.Model
{
    public class Libro
    {

        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public Boolean Prestado { get; set; } = false;


    }
}
