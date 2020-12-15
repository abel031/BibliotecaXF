using BibliotecaXF.Helpers;
using BibliotecaXF.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaXF
{
    public partial class App : Application
    {
        BibliotecaDB bibDB;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuPrincipalView());
            bibDB = new BibliotecaDB();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
