using BibliotecaXF.Helpers.MiEventArgs;
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
    public partial class SocioDetalleView : ContentPage
    {
        private SocioDetalleViewModel vm;

        public SocioDetalleView(Socio seleccionado)
        {
            InitializeComponent();
            vm = new SocioDetalleViewModel { SocioSeleccionado = seleccionado };
            BindingContext = vm;
        }

        private void ClickedGuardar(object sender, EventArgs e)
        {
            bool nuevo = vm.saveSocio();
            if (nuevo)
            {
                OnSaveHandler();
            }
            else
            {
                OnModifyHandler();
            }
            
            
        }

        private void ClickedBorrar(object sender, EventArgs e)
        {
            vm.deleteSocio();
            OnDeleteHandler();
        }

        private void ClickedNuevo(object sender, EventArgs e)
        {
            vm.newSocio();
        }

        public event EventHandler<EventArgsSocio> DeleteHandler;
        private void OnDeleteHandler()
        {
            EventArgsSocio evs = new EventArgsSocio();
            evs.Socio = vm.SocioSeleccionado;
            if (DeleteHandler != null) DeleteHandler(this, evs);
        }

        public event EventHandler<EventArgsSocio> SaveHandler;
        private void OnSaveHandler()
        {
            EventArgsSocio evs = new EventArgsSocio();
            evs.Socio = vm.SocioSeleccionado;
            if (SaveHandler != null) SaveHandler(this, evs);
        }

        public event EventHandler<EventArgsSocio> ModifyHandler;
        private void OnModifyHandler()
        {
            EventArgsSocio evs = new EventArgsSocio();
            evs.Socio = vm.SocioSeleccionado;
            if (ModifyHandler != null) ModifyHandler(this, evs);
        }
    }
}