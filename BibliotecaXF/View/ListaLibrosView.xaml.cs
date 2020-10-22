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
    public partial class ListaLibrosView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListaLibrosView()
        {
            InitializeComponent();
            BindingContext = new ListaLibrosViewModel();

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new LibroDetalleView((Libro)((ListView)sender).SelectedItem));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        async void Clicked_Inserta_Libro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LibroDetalleView(new Libro()));
        }
    }
}
