using System;

namespace Logica
{
    public abstract class Producto
    {
      
        private string nombre;
        private int precio;
        private int numeroDeOrden;
        static int codigo;

        public int NumeroDeOrden { get => numeroDeOrden; }
        static Producto()
        {
            codigo = 1;
        }

        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.numeroDeOrden = codigo++;
        }

    }
}
