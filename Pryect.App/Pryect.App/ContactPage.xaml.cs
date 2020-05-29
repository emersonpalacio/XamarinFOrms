 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pryect.App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage(Contacto contacto)
        {
            InitializeComponent();
            BackgroundColor = Color.FromRgb(48,63,59);
            BindingContext = contacto;
        }
    }
}