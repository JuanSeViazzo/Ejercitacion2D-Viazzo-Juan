namespace Logica
{
    public class Mozo
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int sueldo;
        private int edad;

        public Mozo(int legajo, string nombre, string apellido, int sueldo, int edad)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.edad = edad;
        }

        public int Legajo { get => legajo;}
        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public int Sueldo { get => sueldo;}
        public int Edad { get => edad;}









    }
}