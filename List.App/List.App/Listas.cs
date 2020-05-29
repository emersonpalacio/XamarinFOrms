using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace List.App
{
    public class Listas : ContentPage
    {

        public Listas()
        {
            var nombres = new string[] { "Emerson", "Juana", "Marcos","Undiendo" , "Emmanuel",
                                       "Sara", "turco", "Humberto"};

            var MiListView = new ListView();
            MiListView.ItemsSource = from nombre in nombres
                                     where nombre.StartsWith("H")
                                     select nombre;

            MiListView.ItemSelected += (EventArgs, e) => {
                if (e.SelectedItem == null)
                    Debug.WriteLine("seelcted" + e.SelectedItem);
                MiListView.SelectedItem = null;
            };
            Content = MiListView;

        }
       
    }
}
