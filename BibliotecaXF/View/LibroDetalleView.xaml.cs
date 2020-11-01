using BibliotecaXF.Model;
using BibliotecaXF.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BibliotecaXF.View
{
    public partial class LibroDetalleView : ContentPage
    {
        private LibroDetalleViewModel vm;
        public LibroDetalleView(Libro seleccionado)
        {
            InitializeComponent();
            vm = new LibroDetalleViewModel { LibroSeleccionado = seleccionado };
            BindingContext = vm;
        }

        private void ClickedNuevo(object sender, EventArgs e)
        {
            vm.newLibro();
        }

        private void ClickedGuardar(object sender, EventArgs e)
        {
            vm.saveLibro();
        }

        private void ClickedBorrar(object sender, EventArgs e)
        {
            vm.deleteLibro();
        }
    }
}
