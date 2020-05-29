using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace List.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Listas();
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
