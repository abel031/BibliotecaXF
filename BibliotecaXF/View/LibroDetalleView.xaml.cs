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
        public LibroDetalleView()
        {
            InitializeComponent();
            BindingContext = new LibroDetalleViewModel();
        }
    }
}
