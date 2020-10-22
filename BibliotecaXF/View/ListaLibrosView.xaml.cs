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

            Navigation.PushAsync(new LibroDetalleView());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
            ((ListView)sender).Item
        }
    }
}
