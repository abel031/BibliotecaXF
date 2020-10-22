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
    public partial class MenuPrincipalView : ContentPage
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void ClickedMantenimientoLibros(object sender, EventArgs e)
        {
           Navigation.PushAsync(new ListaLibrosView());
        }

        private void ClickedMantenimientoSocios(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaSociosView());
        }
    }
}