using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public enum TipoDeBebida
    {
        Gaseosa,
        Cerveza,
        Vino,
        Trago,
        Saborizada,
        AguaMineral
    }
    public class Bebida : Producto
    {

        private string nombre;
        private int precio;
        private TipoDeBebida tipoDeBebida;

        public Bebida(string nombre, int precio,TipoDeBebida bebida) : base(nombre, precio)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.tipoDeBebida = bebida;
        }

        public string Nombre { get => nombre;}
        public int Precio { get => precio;}
        public TipoDeBebida TipoDeBebida { get => tipoDeBebida;}
    }
}
