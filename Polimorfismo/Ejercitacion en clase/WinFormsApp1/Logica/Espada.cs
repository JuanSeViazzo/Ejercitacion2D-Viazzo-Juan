using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Espada : Arma
    {


        private int peso;

        public Espada(int daño, int precio, string nombre, string descripcion, int peso) : base(daño, precio, nombre, descripcion)
        {
            this.peso = peso;
        }

        public override string Ataque()
        {
            throw new NotImplementedException();

        }

        public override void Defensa()
        {
            throw new NotImplementedException();
        }

        public override string MensajeAtaque()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"espadazooooo");
            return sb.ToString();
        }

        public override string DescripcionAtaqueDefensa()
        {
            return base.DescripcionAtaqueDefensa();
        }




    }
}
