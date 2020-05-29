using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pryect.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContactPage(new Contacto { 
              Direccion = "carrera 3#45-67",
              Nombre = "texo",
              Telefono ="123"
              
            });
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
