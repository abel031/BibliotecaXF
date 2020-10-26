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
        public DetalleSocioView(Socio seleccionado)
        {
            InitializeComponent();
            BindingContext = new SocioDetalleViewModel { SocioSeleccionado = seleccionado };
        }
    }
}