using BibliotecaXF.Model;
using BibliotecaXF.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaXF.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaSociosView : ContentPage
    {
        SocioViewModel vm;
        public ObservableCollection<string> Items { get; set; }

        public ListaSociosView()
        {
            InitializeComponent();
            vm = new SocioViewModel();
            BindingContext = vm;

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            vm.SocioSeleccionado = ((Socio)((ListView)sender).SelectedItem);
            await Navigation.PushAsync(new SocioDetalleView(vm));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        async void Clicked_Inserta_Socio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SocioDetalleView(new Socio()));
        }
    }
}
