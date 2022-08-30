using System;

namespace Logica
{
    public class Conductor
    {


        public string nombre;
        public float[] kmPorDia;

        private Conductor()
        {
            kmPorDia = new float[7];
        }

        public Conductor(string nombre) : this()
        {
            this.nombre = nombre;
        }



    }
}
