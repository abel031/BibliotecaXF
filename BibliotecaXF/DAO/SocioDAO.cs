using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.DAO
{
    class SocioDAO
    {
        public static void saveSocio(Socio s)
        {
            var pos = BD.Socios.IndexOf(s);
            BD.Socios[pos] = s;
        }

        public static void deleteSocio(Socio s)
        {
            BD.Socios.Remove(s);
        }

        public static void addSocio(Socio s)
        {
            BD.Socios.Add(s);
        }

    }
}
