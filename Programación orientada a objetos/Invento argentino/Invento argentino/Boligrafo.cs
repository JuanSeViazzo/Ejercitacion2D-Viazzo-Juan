using System;

namespace Invento_argentino
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor Color { get => color; set => color = value; }
        public short Tinta
        {
            get => tinta;
            private set
            {
                int resultado;

                if (value >= -100 && value <= 100)
                {
                    if (tinta < 100 && tinta > 0)
                    {
                        resultado = tinta + value;
                        if (resultado > 0 && resultado <= cantidadTintaMaxima)
                        {
                            tinta = (short)resultado;
                        }
                    }
                }
            }
        }
        public void Recargar()
        {
            short tintaActual = Tinta;  // tengo 55 de tinta, y se que el maximo es 100... 100-55 = faltan 45...paso 45 a settinta, y le agrega esos 45 a los 55...
            int tintaFaltante;
            tintaFaltante = (int)cantidadTintaMaxima - (int)tintaActual;
            Tinta = (short)tintaFaltante;
        }

        public bool Pintar(short gasto,out string dibujo)
        {
            short tintaActual = Tinta;
            short tintaResultado = (short)(tintaActual - gasto);
            dibujo = "";
            Tinta = gasto;

            if(tintaResultado > 0)
            {
                dibujo = dibujo.PadRight(tintaResultado, '*');
                return true;

            }else
                return false;





        }








    }
}
