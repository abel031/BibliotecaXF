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
            if (pos >= 0)
            {
                BD.Socios[pos] = s;
            }
            else
            {
                BD.Socios.Add(s);
            }
        }

        public static void deleteSocio(Socio s)
        {
            BD.Socios.Remove(s);
        }

        /*public static void addSocio(Socio s)
        {
            BD.Socios.Add(s);
        }*/

    }
}
