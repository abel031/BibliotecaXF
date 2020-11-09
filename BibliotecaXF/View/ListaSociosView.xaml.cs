using BibliotecaXF.Helpers.MiEventArgs;
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
        public ObservableCollection<string> Items { get; set; }
        private ListaSociosViewModel vm = new ListaSociosViewModel();

        public ListaSociosView()
        {
            InitializeComponent();
            BindingContext = vm;

        }       

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            var sociodetalle = new SocioDetalleView((Socio)e.Item);
            sociodetalle.DeleteHandler += OnDeleteSocioHandler;
            sociodetalle.SaveHandler += OnSaveSocioHandler;
            await Navigation.PushAsync(sociodetalle);

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        async void Clicked_Inserta_Socio(object sender, EventArgs e)
        {
            var sociodetalle = new SocioDetalleView(new Socio());
            sociodetalle.SaveHandler += OnSaveSocioHandler;
            await Navigation.PushAsync(sociodetalle);
        }

        void OnDeleteSocioHandler(object sender, EventArgsSocio e)
        {
            vm.Socios.Remove(e.Socio);
        }
        void OnSaveSocioHandler(object sender, EventArgsSocio e)
        {
            vm.Socios.Add(e.Socio);
        }
    }
}
