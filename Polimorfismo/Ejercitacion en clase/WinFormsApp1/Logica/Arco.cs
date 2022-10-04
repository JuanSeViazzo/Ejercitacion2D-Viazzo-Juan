using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Arco : Arma
    {


        private int peso;

        public Arco(int daño, int precio, string nombre, string descripcion, int peso) : base(daño, precio, nombre, descripcion)
        {
            this.peso = peso;
        }

        public override string Ataque()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Daño: {base.Daño}");
            sb.AppendLine($"{MensajeAtaque()}");

            return sb.ToString();   
        }

        public override void Defensa()
        {
            throw new NotImplementedException();
        }

        public override string MensajeAtaque()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"piiiiuuu piuuuu piuuuuu");
            return sb.ToString();
        }





    }
}
