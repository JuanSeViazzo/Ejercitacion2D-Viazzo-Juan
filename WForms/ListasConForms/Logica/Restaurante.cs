using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Restaurante
    {

        private string nombre;
        private string direccion;

        List<Mesa> mesas;

       
        public string Nombre { get => nombre;}
        public string Direccion { get => direccion;}

        public Restaurante(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.mesas = new List<Mesa>();
        }



    }
}
