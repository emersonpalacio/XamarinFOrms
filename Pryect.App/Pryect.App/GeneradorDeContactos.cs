using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pryect.App
{
    public class GeneradorDeContactos
    {
        

        private static List<string> ListaNombres = new List<string> { 
          "emerson",
          "Rubiela",
          "Emmanuel",
          "Sara",
          "Luz",
          "Dario"
        };

        private static List<string> ListaApellido = new List<string> { 
         "Palacio",
         "Otalvaro",
         "gaviria",
         "Guzman",
         "Restrepo"        
        };

        public static ObservableCollection<Contacto> CrearContacto()
        {
            Random rnd = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for (int i = 0; i < 25; i++)
            {
                var nombre = ListaNombres[rnd.Next(ListaNombres.Count -1)];
                var apellido = ListaApellido[rnd.Next(ListaApellido.Count -1 )];
                var direccion = ListaNombres[rnd.Next(ListaNombres.Count -1)];
                var contacto = new Contacto {
                    Nombre = nombre + " " + apellido,
                    Direccion = "Avenida" + direccion + "numer " + rnd.Next(1, 100),
                    Telefono = GenerarTelefono(),
                };

                contactos.Add(contacto);
            }

            return contactos;

        }

        private static string GenerarTelefono()
        {
            Random rnd = new Random();
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(");
            telefono.Append(rnd.Next(100, 1000));
            telefono.Append(")");
            telefono.Append(rnd.Next(1000000, 9999999));

            return telefono.ToString();

        }
    }
}
