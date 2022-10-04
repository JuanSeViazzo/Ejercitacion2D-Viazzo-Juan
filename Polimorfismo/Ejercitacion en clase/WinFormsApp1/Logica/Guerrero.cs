using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Guerrero : Personaje
    {


        private string clan;
        private string clase;
        public Arma miArma;
        List<Arma> armaList;

        public Guerrero(string nombre, int vida) : base(nombre, vida)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.miArma = miArma;

        }


        public Guerrero(string nombre, int vida, string clan, string clase, Arma miArma) : base(nombre,vida)
        {
            this.clase = clase;
            this.clan = clan;
            this.miArma = miArma;

        }


    }
}
