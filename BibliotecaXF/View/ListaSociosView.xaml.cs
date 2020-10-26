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

        public ListaSociosView()
        {
            InitializeComponent();
            BindingContext = new ListaSociosViewModel();

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new DetalleSocioView((Socio)((ListView)sender).SelectedItem));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        async void Clicked_Inserta_Socio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetalleSocioView(new Socio()));
        }
    }
}
