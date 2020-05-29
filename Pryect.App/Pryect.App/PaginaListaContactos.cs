using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Pryect.App
{
    public  class PaginaListaContactos : MasterDetailPage
    {

        public PaginaListaContactos()
        {
            var list = new ListView();
            list.ItemsSource = GeneradorDeContactos.CrearContacto().OrderBy(x => x.Nombre);

            list.ItemSelected += (sender, e) =>{
                if (e.SelectedItem != null)
                {
                    Detail = new ContactPage(e.SelectedItem as Contacto);
                    IsPresented = false;
                }

            };

            Master = new ContentPage { Title ="Contactos", Content = list};


            Detail = new ContactPage(GeneradorDeContactos.CrearContacto().First());
        }



    }
}
