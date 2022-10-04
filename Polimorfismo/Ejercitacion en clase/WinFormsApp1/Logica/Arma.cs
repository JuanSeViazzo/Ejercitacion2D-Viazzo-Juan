using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Arma
    {



        private int daño;
        private int precio;
        private string nombre;
        private string descripcion;

        protected Arma(int daño, int precio, string nombre, string descripcion)
        {
            this.daño = daño;
            this.precio = precio;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int Daño { get => daño; }
        public string Nombre { get => nombre;}
        public string Descripcion { get => descripcion;}

        public abstract string Ataque();

        public abstract void Defensa();


        public virtual string DescripcionAtaqueDefensa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{nombre} \n Descripcion {descripcion} \n Daño {daño} \n Precio: {precio}");
            return sb.ToString();   
        }

        public abstract string MensajeAtaque();
        




    }
}
