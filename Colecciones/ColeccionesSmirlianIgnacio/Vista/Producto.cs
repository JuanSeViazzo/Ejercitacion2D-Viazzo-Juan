using System;
using System.Text;

namespace Vista
{
    public class Producto
    {

        string nombre;
        int precio;
        static int codigoDeBarra;
        int codigo;
        static Producto()
        {
            codigoDeBarra = 1000; 
        }

        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.codigo = codigoDeBarra++;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.Append($"{nombre}");
            sb.Append($" Precio: {precio}"); 
            sb.Append($" Codigo: {codigo}");

            return sb.ToString();
        }

    }


}