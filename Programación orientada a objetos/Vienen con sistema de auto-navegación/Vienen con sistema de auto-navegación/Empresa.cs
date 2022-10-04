namespace Logica
{
    public class Empresa
    {

        public Conductor[] conductores;
        private string nombre;
        private Empresa()
        {
            conductores = new Conductor[3];
        }

        public Empresa(Conductor[] conductores)
        {
            this.conductores = conductores; 
        }



        public Empresa(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Conductor MayorKmConductor()
        {
            float masKm;
            float conductorMas = 0;
            Conductor conductorRetorno = null;

            foreach (Conductor item in conductores)
            {
                masKm = KmSemanalPorConductor(item);

                if (masKm > conductorMas)
                {
                    conductorMas = masKm;
                    conductorRetorno = item;
                }
            }

            return conductorRetorno;
        }





        public float KmSemanalPorConductor(Conductor conductor)
        {
            float acumulador = 0;

            for (int i = 0; i < conductor.kmPorDia.Length; i++)
            {
                acumulador += conductor.kmPorDia[i];
            }

            return acumulador;

        }











    }








}

