using BibliotecaXF.Helpers;
using BibliotecaXF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaXF.ViewModel
{
    class SocioDetalleViewModel
    {
        public Socio SocioSeleccionado { get; set; }

        public void saveSocio()
        {
            BD.saveSocio(SocioSeleccionado);
        }

        public void deleteSocio()
        {
            BD.deleteSocio(SocioSeleccionado);
        }
    }
}
