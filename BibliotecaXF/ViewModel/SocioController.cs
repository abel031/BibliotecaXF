using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Controlador
{
    class SocioController
    {
        public static Socio GetSocio(String dni)
        {
            foreach(Socio s in BD.Socios)
            {
                if (s.DNI == dni) return s;
            }
            return null;
        }
    }
}
