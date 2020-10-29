using BibliotecaXF.Model;
using BibliotecaXF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaXF.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleSocioView : ContentPage
    {
        private SocioDetalleViewModel vm;
        public DetalleSocioView(Socio seleccionado)
        {
            InitializeComponent();
            vm = new SocioDetalleViewModel { SocioSeleccionado = seleccionado };
            BindingContext = vm;
        }

        private void ClickedGuardar(object sender, EventArgs e)
        {
           vm.saveSocio();
        }

        private void ClickedBorrar(object sender, EventArgs e)
        {
            vm.deleteSocio();
        }

        private void ClickedNuevo(object sender, EventArgs e)
        {
            vm.newSocio();
        }
    }
}