using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Hacha : Arma
    {


        private int peso;

        public Hacha(int daño, int precio, string nombre, string descripcion, int peso) : base(daño, precio, nombre, descripcion)
        {
            this.peso = peso;
        }

        public override string Ataque()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"daño realizado {base.Daño}, con {base.Nombre} y {base.Descripcion}");
            return sb.ToString();

        }

        public override void Defensa()
        {
            throw new NotImplementedException();
        }

        public override string MensajeAtaque()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"zaaaaaaaaaaaaazzzz");
            return sb.ToString();
        }





    }
}
