namespace Logica
{
    public class Mesa
    {

        private int numeroDeMesa;
        private int montoFinal;
        private int cantidadDeComensales;
        private Mozo mozo;

        public Mesa(int numeroDeMesa, int montoFinal, int cantidadDeComensales, Mozo mozo)
        {
            this.numeroDeMesa = numeroDeMesa;
            this.montoFinal = montoFinal;
            this.cantidadDeComensales = cantidadDeComensales;
            this.mozo = mozo;
        }

        public int NumeroDeMesa { get => numeroDeMesa;}
        public int MontoFinal { get => montoFinal;}
        public int CantidadDeComensales { get => cantidadDeComensales;}
        public Mozo Mozo { get => mozo;
        
        
        
        }
    }
}