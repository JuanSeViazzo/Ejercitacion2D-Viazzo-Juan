using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Postre : Producto
    {

        private string nombre;
        private int precio;


        public Postre(string nombre, int precio) : base(nombre, precio)
        {
            this.precio = precio;
            this.nombre = nombre;
        }

        public string Nombre { get => nombre;}
        public int Precio { get => precio;}
    }
}
